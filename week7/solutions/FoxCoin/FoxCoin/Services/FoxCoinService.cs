using System;
using System.Collections.Generic;
using System.Linq;
using FoxCoin.Models;
using Microsoft.EntityFrameworkCore;

namespace FoxCoin.Services
{
    public class FoxCoinService : IFoxCoinService
    {
        private readonly ApplicationContext applicationContext;
        private readonly int maxRetryCount;

        public FoxCoinService(ApplicationContext applicationContext, int maxRetryCount = 1)
        {
            this.applicationContext = applicationContext;
            this.maxRetryCount = maxRetryCount;
        }

        public int GenerateRandomFoxCoin(UserAccount userAccount)
        {
            if (userAccount == null)
            {
                throw new ArgumentNullException(nameof(userAccount));
            }

            if (userAccount.Id == 0)
            {
                throw new ArgumentException("Invalid user account id: 0");
            }

            applicationContext.Attach(userAccount);

            var random = new Random();
            int amount = random.Next(10, 1000);
            userAccount.Balance += amount;

            applicationContext.SaveChanges();

            return amount;
        }

        public FoxCoinTransferResult Transfer(UserAccount fromAccount, UserAccount targetAccount, decimal amount)
        {
            int retryCount = 0;

            while (retryCount < maxRetryCount)
            {
                try
                {
                    applicationContext.Entry(fromAccount).Reload();
                    applicationContext.Entry(targetAccount).Reload();

                    if (applicationContext.Entry(fromAccount).State == EntityState.Detached ||
                        applicationContext.Entry(targetAccount).State == EntityState.Detached)
                    {
                        return FoxCoinTransferResult.Failed("Invalid account id", FoxCoinTransferStatus.InvalidAccounts);
                    }

                    if (fromAccount.Balance < amount)
                    {
                        return FoxCoinTransferResult.Failed("Not enough FoxCoin to transfer", FoxCoinTransferStatus.InvalidAccounts);
                    }

                    fromAccount.Balance -= amount;
                    targetAccount.Balance += amount;

                    applicationContext.Transactions.Add(new Transaction
                    {
                        Sender = fromAccount,
                        Receiver = targetAccount,
                        Amount = amount,
                        Timestamp = DateTime.UtcNow
                    });

                    applicationContext.SaveChanges();

                    return FoxCoinTransferResult.Succeeded();
                }
                catch (DbUpdateConcurrencyException)
                {
                    retryCount++;
                }
                catch (DbUpdateException)
                {
                    return FoxCoinTransferResult.Failed("Database update issue", FoxCoinTransferStatus.UpdateFailed);
                }
            }

            return FoxCoinTransferResult.Failed("Couldn't commit the transfer, please try again.", FoxCoinTransferStatus.ConcurrencyIssue);
        }

        public void GrantCoins(UserAccount userAccount, int amount)
        {
            if (amount <= 0)
            {
                return;
            }

            applicationContext.Entry(userAccount).Reload();

            userAccount.Balance += amount;

            applicationContext.SaveChanges();
        }

        public IEnumerable<Transaction> GetTransactionHistory(UserAccount currentAccount, long? receiverId, long? senderId)
        {
            var result = applicationContext.Transactions
                .Include(t => t.Sender)
                .Include(t => t.Receiver)
                .OrderByDescending(t => t.Timestamp)
                .Where(t => t.ReceiverId == currentAccount.Id || t.SenderId == currentAccount.Id);

            if (receiverId != null)
            {
                result = result.Where(t => t.ReceiverId == receiverId);
            }

            if (senderId != null)
            {
                result = result.Where(t => t.SenderId == senderId);
            }

            return result;
        }

        public TransactionStatistics GetStatistics()
        {
            return applicationContext.TransactionStatistics.Single();
        }
    }

    public enum FoxCoinTransferStatus
    {
        UpdateFailed = 1,
        InvalidAccounts = 2,
        ConcurrencyIssue = 3
    }

    public sealed class FoxCoinTransferResult
    {
        public bool IsSucceeded { get; }

        public string Reason { get; }

        public FoxCoinTransferStatus Status { get; }

        private FoxCoinTransferResult(bool isSucceeded, string reason, FoxCoinTransferStatus status)
        {
            IsSucceeded = isSucceeded;
            Reason = reason;
            Status = status;
        }

        public static FoxCoinTransferResult Failed(string reason, FoxCoinTransferStatus status)
        {
            return new FoxCoinTransferResult(false, reason, status);
        }

        public static FoxCoinTransferResult Succeeded()
        {
            return new FoxCoinTransferResult(true, "", 0);
        }
    }
}
using System.Collections.Generic;
using FoxCoin.Models;

namespace FoxCoin.Services
{
    public interface IFoxCoinService
    {
        int GenerateRandomFoxCoin(UserAccount userAccount);
        FoxCoinTransferResult Transfer(UserAccount fromAccount, UserAccount targetAccount, decimal amount);
        void GrantCoins(UserAccount userAccount, int amount);
        IEnumerable<Transaction> GetTransactionHistory(UserAccount currentAccount, long? receiverId, long? senderId);
        TransactionStatistics GetStatistics();
    }
}
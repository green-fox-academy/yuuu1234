using System.Collections.Generic;
using System.Linq;
using FoxCoin.Models;
using Microsoft.EntityFrameworkCore;

namespace FoxCoin.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationContext applicationContext;

        public AccountService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IEnumerable<UserAccount> GetAccounts()
        {
            return applicationContext.UserAccounts;
        }

        public UserAccount FindById(long accountId)
        {
            return applicationContext.UserAccounts.Find(accountId);
        }

        public void Delete(long accountId)
        {
            var userAccount = applicationContext.UserAccounts.Find(accountId);
            applicationContext.Transactions.Where(t => t.Receiver.Id == userAccount.Id || t.SenderId == userAccount.Id).Load();

            if (userAccount == null)
            {
                return;
            }

            applicationContext.UserAccounts.Remove(userAccount);
            applicationContext.SaveChanges();
        }

    }
}
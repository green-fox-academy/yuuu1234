using System;
using FoxCoin.Models;

namespace FoxCoin.Services
{
    public sealed class CurrentAccountService : ICurrentAccountService
    {
        private readonly IAccountService accountService;

        public CurrentAccountService(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        private static UserAccount currentAccount;

        public UserAccount CurrentAccount => currentAccount;

        public void SwitchTo(long accountId)
        {
            var userAccount = accountService.FindById(accountId);

            currentAccount = userAccount ?? throw new ArgumentException($"{nameof(accountId)}: {accountId} not found");
        }
    }
}
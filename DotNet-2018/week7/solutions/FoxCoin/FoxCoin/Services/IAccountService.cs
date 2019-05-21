using System.Collections.Generic;
using FoxCoin.Models;

namespace FoxCoin.Services
{
    public interface IAccountService
    {
        IEnumerable<UserAccount> GetAccounts();
        UserAccount FindById(long accountId);
        void Delete(long accountId);
    }
}
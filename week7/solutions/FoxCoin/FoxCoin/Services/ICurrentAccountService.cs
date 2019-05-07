using FoxCoin.Models;

namespace FoxCoin.Services
{
    public interface ICurrentAccountService
    {
        UserAccount CurrentAccount { get; }
        void SwitchTo(long accountId);
    }
}
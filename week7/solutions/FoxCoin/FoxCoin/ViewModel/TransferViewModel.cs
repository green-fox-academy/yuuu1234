using System.Collections.Generic;
using FoxCoin.Models;

namespace FoxCoin.ViewModel
{
    public class TransferViewModel
    {
        public UserAccount FromAccount { get; set; }
        public IReadOnlyList<UserAccount> Accounts { get; set; }
    }
}

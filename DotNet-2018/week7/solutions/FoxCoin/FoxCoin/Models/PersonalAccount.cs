using System.Collections.Generic;

namespace FoxCoin.Models
{
    public class PersonalAccount : UserAccount
    {
        public ICollection<PersonalAccount> Friends { get; set; }

        public PersonalAccount Friend { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models.BankOfSimba
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }
        public string PersonalImage { get; set; }
        public  bool King { get; private set; }
        public BankAccount(string name, float balance, string type,string image, bool king)
        {
            this.Name = name;
            this.Balance = balance.ToString("F");
            this.AnimalType = type;
            this.Currency = "zebra";
            this.PersonalImage = image;
            this.King = king;
        }

        public BankAccount()
        {
            this.Currency = "zebra";

        }

    }
}

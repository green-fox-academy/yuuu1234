using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StructAndGeneric
{
    public enum Currency { Font, Dollar, Yuan, Forint }

    public struct Prize
    {
        public readonly int Amount;
        public readonly string Currency;

        public Prize(int prize, Currency c)
        {
            this.Amount = prize;
            this.Currency = c.ToString();
        }
    }
    class Participant
    {
        public Prize Prize { get; set; }
        public string Name { get; set; }
    
        public Participant(string name)
        {
            this.Name = name;
            Random r =new Random();
            this.Prize=new Prize(r.Next(1000,10001),(Currency)r.Next(0,4));
        }

        public void ChangePrize()
        {
            Random r=new Random();
            this.Prize = new Prize(this.Prize.Amount / 2,(Currency)r.Next(0,4));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation
{
    class Reservation : IReservationy
    {
        public readonly string Dow;
        public readonly string Code;

        public Reservation(string dow,string code)
        {
            this.Dow = dow;
            this.Code = code;
        }
        public string GetCodeBooking()
        {
            return this.Dow;
        }

        public string GetDowBooking()
        {
            return this.Code;
        }
    }
}

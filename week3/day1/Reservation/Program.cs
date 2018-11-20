using System;
using System.Collections.Generic;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Reservation> reslist = new List<Reservation>();
            Reservation r1=new Reservation(" 1WBA3OMU","THU");
            Reservation r2 = new Reservation(" 0V5OH7VS", "WED");
            Reservation r3 = new Reservation(" CV6QOAJO", "MON");
            Reservation r4 = new Reservation(" 03GHEJMV", "SAT");
            Reservation r5 = new Reservation(" S0R70GMN", "SAT");
            Reservation r6 = new Reservation(" 3E032B3C", "WED");
            Reservation r7 = new Reservation(" OD27E36J", "SAT");
            Reservation r8 = new Reservation(" 4MEU0657", "MON");
            reslist.Add(r1);
            reslist.Add(r2);
            reslist.Add(r3);
            reslist.Add(r4);
            reslist.Add(r5);
            reslist.Add(r6);
            reslist.Add(r7);
            reslist.Add(r8);

            foreach (var r in reslist)
            {
                Console.WriteLine("Booking# "+r.GetCodeBooking()+" for "+r.GetDowBooking());
            }

        }
    }
}

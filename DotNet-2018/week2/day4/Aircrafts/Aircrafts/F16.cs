using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AircraftsCarrier
{
    class F16:Aircraft
    {
        public void test()
        {
            this.TrackAmmo();
        }

        public F16():base("F16")
        {
            
        }
    }
}

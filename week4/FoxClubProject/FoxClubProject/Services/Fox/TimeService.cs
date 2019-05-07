using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Interfaces;

namespace FoxClubProject.Services.Fox
{
    public class TimeService : ITimeService
    {
        public DateTime StartTime;
     
        public TimeService()
        {
            this.StartTime=DateTime.Now;
        }
        public DateTime GetStartTime()
        {
            return this.StartTime;
        }
    }
}

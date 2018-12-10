using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week5Day2.Models
{
    public class Todo
    {
        //Add a
        //(Id: long, Title: string, IsUrgent: boolean(default false), IsDone: boolean(default false))
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; } = false;
        public bool IsDone { get; set; } = false;

        public Todo()
        {
            
        }



    }
}

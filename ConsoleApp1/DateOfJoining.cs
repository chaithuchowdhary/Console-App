using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DateOfJoining
    {
        public int day{ get; set; }
        public int mon { get; set; }
        public int year { get; set; }

        public DateOfJoining(int day, int mon, int year)
        {
            this.day = day;
            this.mon = mon;
            this.year = year;
        }
    }
}

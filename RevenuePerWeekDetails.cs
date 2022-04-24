using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagment
{
    public class RevenuePerWeekDetails
    {
        public string MovieName { get; set; }
        public long RevenuePerWeek { get; set; }
        public int Week { get; set; }

        public RevenuePerWeekDetails() { }
        public RevenuePerWeekDetails(string movieName, long revenuePerWeek,int week)
        {
            MovieName = movieName;
            RevenuePerWeek = revenuePerWeek;
            Week = week;
        }
    }
}

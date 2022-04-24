using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagment
{
    public class MovieStatusWeekly
    {
        /*
        * @className - MovieStatusWeekly
        * @objective - creating getter setter for MovieStatusWeekly
        */
        public string MovieName { get; set; }

        public string Status { get; set; }
        public int Week { get; set; }
        
        public MovieStatusWeekly() { }

        public MovieStatusWeekly(string movieName,string status,int week)
        {
            MovieName = movieName;
            Status = status;
            Week = week;

        }
    }
}

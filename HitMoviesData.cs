using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagment
{
    public class HitMoviesData
    {
        /*
         * @className - HitMoviesData
         * @objective - getter setter for HitMoviesData
         */
        public string MovieName { get; set; }
        public int TotalRevenue { get; set; }
       // public int HitCount { get; set; }
        
        public HitMoviesData() { }
        public HitMoviesData(string movieName, int totalRevenue)
        {
            this.MovieName = movieName;
            this.TotalRevenue = totalRevenue;
          //  this.HitCount = hitCount;

            

        }
    }
}

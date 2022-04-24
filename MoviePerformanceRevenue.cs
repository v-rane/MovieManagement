using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagment
{
    public class MoviePerforManceRevenue
    {
        /*
         * @className - HitMoviesData
         * @objective - creating getter setter for 
         */
        public string MovieName { get; set; }
        public string Performance { get; set; }
        public long Revenue { get; set; }
        public int Weeks { get; set; }
        public int NumberOfShows { get; set; }

        public MoviePerforManceRevenue() { }
        public override string ToString()
        {
            return MovieName+ "," + Performance + "," + Revenue;
        }
    }
}

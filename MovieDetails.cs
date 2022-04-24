using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagment
{
    /*
     * @className -MovieDetails
     * @objective - creating getter setter for movieData 
     */
    public class MovieDetails
    {
        public string MovieName { get; set; }
        public int NumberOfShows { get; set; }
        public long Revenue { get; set; }
        public string Status { get; set; }
        public int Week { get; set; }
        public MovieDetails(){}

        public MovieDetails( string movieName, int numberOfShows, long revenue,string status,int week)
        {
            this.MovieName = movieName;
            this.NumberOfShows = numberOfShows;
            this.Revenue = revenue;
            this.Status = status;
            this.Week = week;
        }
    }
}

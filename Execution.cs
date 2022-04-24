using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagment
{
    public class Execution
    {
        /*
         * @className -Execution
         * @objective - to do orcastation of program by calling several methods  
         */
        static void Main(string[] args)
        {
            List<MovieDetails> list = new List<MovieDetails>();
            //adding values in object of MovieDetails 

            MovieDetails movieDetails1 = new MovieDetails("RRR",60, 400000000,"Hit",1);
            MovieDetails movieDetails2 = new MovieDetails("KGF",90, 750000000,"Hit",1);
            MovieDetails movieDetails3 = new MovieDetails("Attack",35, 80000000,"Average",1);
            MovieDetails movieDetails4 = new MovieDetails("SpiderMan",120, 900000000,"Hit",1);
            MovieDetails movieDetails5 = new MovieDetails("RRR",40, 300000000,"Hit",2);
            MovieDetails movieDetails6 = new MovieDetails("KGF",60, 450000000,"Hit",2);
            MovieDetails movieDetails7 = new MovieDetails("Attack",45, 95000000,"Hit",2);
            MovieDetails movieDetails8 = new MovieDetails("SpiderMan", 75, 300000000, "Average",2);
            //adding values in created list by passing object of MovieDetails
            list.Add(movieDetails1);
            list.Add(movieDetails2);
            list.Add(movieDetails3);
            list.Add(movieDetails4);
            list.Add(movieDetails5);
            list.Add(movieDetails6);
            list.Add(movieDetails7);
            list.Add(movieDetails8);
            
            //object is created of operationsOnMovieDetails
            OperationsOnMovieDetails operationsOnMovieDetails = new OperationsOnMovieDetails();

            //problem 1: 
            //creating list of RevenuePerWeekDetails for assigning result of getRevenuePerWeek
            List< RevenuePerWeekDetails > resList = operationsOnMovieDetails.getRevenuePerWeek(list);
            foreach(RevenuePerWeekDetails value in resList)
            {
                Console.WriteLine(value.MovieName +", "+ value.RevenuePerWeek +","+ value.Week);
            }

            //problem 2:-
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("total revenue for all hit movies accross all weeks");
            Console.WriteLine("movie name :    Total revenue:  ");  
            //creating list of HitMoviesData for assigning result of getHitMoviesRevenue
            List<HitMoviesData> resList2 = operationsOnMovieDetails.getHitMoviesRevenue(list);
            foreach (HitMoviesData value in resList2)
            {
                Console.WriteLine(value.MovieName + ", " + value.TotalRevenue );
            }

            //problem 3:
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("the movies which have changed in status in weekly level:");
            //creating list of MovieStatusWeekly for assigning result of getMoviesByStatus 
            List<MovieStatusWeekly> resultMap3 = operationsOnMovieDetails.getMoviesByStatus(list);
            foreach(MovieStatusWeekly value in resultMap3)
            {
                Console.WriteLine(value.MovieName +" , " + value.Status +" ," + value.Week );
            }

            //problem 4: 
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(" revenue per show increase or decrease for movies on week-2 compare to week-1 level:");
            Console.WriteLine("Movie Name:   revenue:     performance:");
            //creating list of MoviePerformanceRevenue for assigning result of getMoviePerformanceRevenue
            List<MoviePerforManceRevenue> Resultlist4 = operationsOnMovieDetails.getMoviePerformanceRevenue(list);
            foreach(MoviePerforManceRevenue value in Resultlist4)
            {
                Console.WriteLine(value.MovieName + " , " + value.Revenue + " , " + value.Performance);
            }
        }
    }
}

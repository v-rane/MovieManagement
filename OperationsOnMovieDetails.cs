using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagment
{
    /*
     * @className - OperationsOnMovieDetails
     * @objective - to perform operations on movieData 
     * @Date - 19-4-22
     * @auther Name - Varsha rane
     */
    public class OperationsOnMovieDetails
    {
        //    using tupple useful if week changes
        //    public list<revenueperweekdetails> getrevenueperweek(list<moviedetails> list)
        //{ //using tuple
        //    tuple<string, int> tuple;
        //    // dictionary<tuple<string, int>, revenueperweekdetails> dic = new dictionary<tuple<string, int>, revenueperweekdetails>();
        //    list<revenueperweekdetails> resultlist = new list<revenueperweekdetails>();
        //    foreach (moviedetails movie in list)
        //    {
        //        tuple = tuple.create(movie.moviename, movie.week);
        //        int perweekrevenue = movie.revenue / movie.numberofshows;
        //        if (dic.containskey(tuple))
        //        {
        //            dic[tuple].revenueperweek += perweekrevenue;

        //        }
        //        else
        //        {
        //            dic.add(tuple, new revenueperweekdetails(movie.moviename, perweekrevenue, movie.week));
        //        }

        //    }
        //    foreach (var data in dic.values)
        //    {
        //        resultlist.add(data);
        //    }


        //    return resultlist;


        /*
         *@methodname -  getrevenueperweek
         *@objective - to find revenue per movie per shows in week-1 and week-2
         *@para - list<moviedetails>
         *@return -list<revenueperweekdetails>
         */
        public List<RevenuePerWeekDetails> getRevenuePerWeek(List<MovieDetails> list)
        {
            //list is created of RevenuePerWeekDetails for storing result
            List<RevenuePerWeekDetails> resultList = new List<RevenuePerWeekDetails>();
            //iterating passed list
            foreach (MovieDetails movie in list)
            {
                //assigning values in resultList
                RevenuePerWeekDetails revenuePerWeekDetails = new RevenuePerWeekDetails();
                revenuePerWeekDetails.MovieName = movie.MovieName;
                revenuePerWeekDetails.Week = movie.Week;
                //logic - total revenue = revenue/ noOfShows
                revenuePerWeekDetails.RevenuePerWeek = movie.Revenue / movie.NumberOfShows;
                //adding  object revenuePerWeekDetails in resultlist
                resultList.Add(revenuePerWeekDetails);
            }
            return resultList;
        }
        //**********************************************************************************************************************************************************
        /*
         * @MethodName - getHitMoviesRevenue
         * @objective - to find total revenue for all hit movie across all weeks
         * @para - List<MovieDetails>
         * @return - List<HitMoviesData>
         */
        public List<HitMoviesData> getHitMoviesRevenue(List<MovieDetails> list)
        {
            //dictionary is creating where movieName is key and object of HitMoviesData is passed as value
            Dictionary<string, HitMoviesData> Dic = new Dictionary<string, HitMoviesData>();
            //list  is creating of HitMoviesData object type
            List<HitMoviesData> resultList = new List<HitMoviesData>();

            foreach (MovieDetails movie in list)
            {

                if (movie.Status == "Hit")
                {
                    if (Dic.ContainsKey(movie.MovieName))
                    {
                        //if movie is hit then add=> revenue to the existing revenue in the Dic (for the same movie)
                        Dic[movie.MovieName].TotalRevenue = Convert.ToInt32(Dic[movie.MovieName].TotalRevenue + movie.Revenue);
                    }
                    else
                    {
                        //if dic does not contains movie name  => object of hitMovieData created and values are added
                        HitMoviesData hitMoviesData = new HitMoviesData();
                        //adding keys in movieData
                        Dic.Add(movie.MovieName, hitMoviesData);
                        Dic[movie.MovieName].MovieName = movie.MovieName;
                        Dic[movie.MovieName].TotalRevenue = Convert.ToInt32(movie.Revenue);
                    }
                }
            }
            //adding values of Dic in list
            foreach (HitMoviesData data in Dic.Values)
            {
               resultList.Add(data);
            }
         return resultList;
        }

            //*******************************************************************************************************************************************************
            /*
             * @methodName - getMoviesByStatus
             * @objective - Show movies which are changed in status in weekly level
             * @para -List<MovieDetails>
             * @return - List<MovieStatusWeekly>
             */
            public List<MovieStatusWeekly> getMoviesByStatus(List<MovieDetails> list)
            {
                //dic is creating with taking key as movieName and value as object of MovieStatusWeekly
                Dictionary<string, MovieStatusWeekly> dic = new Dictionary<string, MovieStatusWeekly>();
                //resultList for storing MovieStatusWeekly object
                List<MovieStatusWeekly> resultList = new List<MovieStatusWeekly>();
                foreach (MovieDetails movieData in list)
                {
                    //creating object of movieStatusWeekly for storing result values 
                    MovieStatusWeekly movieStatusWeekly = new MovieStatusWeekly();

                    if (dic.ContainsKey(movieData.MovieName))
                    {
                        //logic - if status of movieData is not same as existing dic then add moviedata in movieStatusWeekly
                        if (movieData.Status != dic[movieData.MovieName].Status)
                        {
                            movieStatusWeekly.MovieName = movieData.MovieName;
                            movieStatusWeekly.Status = movieData.Status;
                            movieStatusWeekly.Week = movieData.Week;
                            //adding values in list
                            resultList.Add(movieStatusWeekly);
                            // previously stored values from the dic and adding into list(for duplicate data i.e. movie RRR repeating)
                            resultList.Add(dic[movieData.MovieName]);
                        }
                    }
                    else
                    {
                        //if movie name is not there in dic then values are added in movieStatusWeekly object
                        movieStatusWeekly.MovieName = movieData.MovieName;
                        movieStatusWeekly.Status = movieData.Status;
                        movieStatusWeekly.Week = movieData.Week;
                        dic.Add(movieData.MovieName, movieStatusWeekly);
                    }
                }
                return resultList;

            }
            //***************************************************************************************************************************************************************

            /*
             * @MethodName - getMoviePerformanceRevenue
             * @objective - to show revenue per show increase or decrease for movies on week-2 compare to week-1 level
             * @return -List<MoviePerformanceRevenue>
             * @para - List<MovieDetails> 
             */
            public List<MoviePerforManceRevenue> getMoviePerformanceRevenue(List<MovieDetails> list)
            {
                //dic is creating with key as movie name and values as object of MoviePerformanceRevenue type
                Dictionary<string, MoviePerforManceRevenue> dic = new Dictionary<string, MoviePerforManceRevenue>();
                //resultlist of MoviePerformanceRevenue object type is created
                List<MoviePerforManceRevenue> resList = new List<MoviePerforManceRevenue>();

                foreach(MovieDetails movieDetails in list)
                {
                    //creating object of moviePerformanceRevenue for storing result in it
                    MoviePerforManceRevenue moviePerformanceRevenue = new MoviePerforManceRevenue();
                    if (dic.ContainsKey(movieDetails.MovieName))
                    {
                        //adding values in object of moviePerformanceRevenue
                        moviePerformanceRevenue.MovieName = movieDetails.MovieName;
                        moviePerformanceRevenue.Revenue = movieDetails.Revenue / movieDetails.NumberOfShows;
                        //existing revenue in dic is smaller than currently passed revenue of moviePerformanceRevenue than add the values in object 
                        if (dic[movieDetails.MovieName].Revenue <= moviePerformanceRevenue.Revenue)
                        {
                            moviePerformanceRevenue.Performance = "Increment";
                            moviePerformanceRevenue.Revenue = (dic[moviePerformanceRevenue.MovieName].Revenue - moviePerformanceRevenue.Revenue);
                            resList.Add(moviePerformanceRevenue);
                        }
                        else
                        {
                            //if revenue of existing dic is greater than currently passed moviePerformanceRevenue than add values in objects
                            moviePerformanceRevenue.Performance = "Decrement";
                            moviePerformanceRevenue.Revenue = (dic[moviePerformanceRevenue.MovieName].Revenue - moviePerformanceRevenue.Revenue);
                            resList.Add(moviePerformanceRevenue);
                        }
                    }
                    else
                    {
                        //if movie name key is not present in dic than add values in dic
                        moviePerformanceRevenue.MovieName = movieDetails.MovieName;
                        moviePerformanceRevenue.Revenue = movieDetails.Revenue / movieDetails.NumberOfShows;
                        dic.Add(movieDetails.MovieName, moviePerformanceRevenue);

                    }

                }
                return resList;
            }


        
    }
}
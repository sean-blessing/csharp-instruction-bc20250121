using BmdbFileIO.DB;
using BmdbFileIO.Model;
using ConsoleUtil;

namespace BmdbFileIO.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Bmdb File IO!\n");

            //Movie m1 = new Movie(1, "Spaceballs", 1985, "PG", "Mel Brooks");
            //Movie m2 = new Movie(2, "Totally Awesome", 2025, "PG-13", "Sean Blessing");

            List<Movie> movies = new List<Movie>();
            //movies.Add(m1);
            //movies.Add(m2);

            //MovieDB.SaveMovies(movies);

            // read from the file and print to the console
            movies = MovieDB.GetMovies();
            //foreach (Movie movie in movies) {
            //    MyConsole.PrintLine(movie.ToString());
            //}
            movies.ForEach(m => m.Title += "!");
            movies.ForEach(m => MyConsole.PrintLine(m.ToString()));



            MyConsole.PrintLine("\nBye");
        }
    }
}

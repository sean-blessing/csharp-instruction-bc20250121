using BmdbFileIO.Model;
using System.Runtime.CompilerServices;

namespace BmdbFileIO.DB
{
    internal class MovieDB
    {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "Movies.txt";
        private const string Sep = "|";

        public static void SaveMovies(List<Movie> movies)
        {
            using StreamWriter writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (Movie m in movies)
            {
                writer.Write(m.Id + Sep);
                writer.Write(m.Title + Sep);
                writer.Write(m.Year + Sep);
                writer.Write(m.Rating + Sep);
                writer.WriteLine(m.Director);
            }
        }

        public static List<Movie> GetMovies()
        {
            using StreamReader reader = new(new FileStream(Path, FileMode.Open, FileAccess.Read));
            List<Movie> movies = new List<Movie>();
            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine();
                string[] cols = row.Split(Sep);

                if (cols.Length == 5)
                {
                    int id = int.Parse(cols[0]);
                    string title = cols[1];
                    int year = int.Parse(cols[2]);
                    string rating = cols[3];
                    string director = cols[4];
                    Movie m = new Movie(id, title, year, rating, director);
                    movies.Add(m);
                }
            }
            return movies;
        }

    }
}

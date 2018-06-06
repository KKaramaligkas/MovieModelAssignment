using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieModel
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfReviewers = 15;
            Console.WriteLine("Top Movies By Rating");

            List<Movie> topmovies = new List<Movie>()
            {
                new Movie {Title="Spider-Man Homecoming", Actors="Tom Holland,Michael Keaton", Sales= 334000000 },
                new Movie {Title="Solo:A Star Wars Story", Actors="Alden Ehrenreich,Woody Harrelson", Sales= 148000000},
                new Movie {Title="Pulp Fiction", Actors="John Travolta,Uma Thurman, Samuel Jackson", Sales= 107928762},
                new Movie {Title="Deadpool 2", Actors="Ryan Reynolds", Sales= 254506035},
                new Movie {Title="Taxi Driver", Actors="Robert De Niro", Sales= 2826574},
                new Movie {Title="The Godfather", Actors="Al Pacino, Marlon Brando", Sales=134966411},
                new Movie {Title="Batman-The Dark Knight", Actors="Christian Bale, Heath Ledger", Sales=534858444},
                new Movie {Title="The Matrix", Actors="Keanu Reeves, Laurence Fishburne", Sales=171479930},
                new Movie {Title="Inception", Actors="Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", Sales=292576195},
                new Movie {Title="Gladiator", Actors="Russell Crowe, Joaquin Phoenix", Sales=187705427},

            };

            foreach (var movie in topmovies)
            {
                movie.ReviewRate = new int[NumberOfReviewers];
                movie.Reviews = new string[NumberOfReviewers];
                movie.Rrating(NumberOfReviewers);
            }

            foreach (var movie in topmovies)
            {
                string Final_Rating = String.Format("{0:F1}", movie.Rating);
                string Rev = String.Format("{0}", movie.Reviews);
                Console.WriteLine(movie.Title + " " + movie.Actors + " " + movie.Sales + " " + Final_Rating);
                Console.WriteLine();
                Console.WriteLine(Rev);
                Console.WriteLine();
            }
        }
    }

    public class Movie
    {
        public Movie() { }

        public Movie(string title, string actors, int sales)
        {
            Title = title;
            Actors = actors;
            Sales = sales;
        }
        public int x = 0;

        public int Sales { get; set; }

        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        
        public string Actors { get; set; }

        public int[] BOffice { get; set; }

        private string[] _Reviews;
        public string[] Reviews
        {
            get
            {
                return _Reviews;
            }
            set
            {
                _Reviews = value;
            }
        }

        private int[] _ReviewRate;
        public int[] ReviewRate
        {
            get
            {
                return _ReviewRate;
            }
            set
            {
                _ReviewRate = value;
            }
        }

        private decimal _Rating;
        public decimal Rating
        {
            get
            {
                return _Rating;
            }
            set
            {
                _Rating = value;
            }
        }

        public void Rrating(int metr)
        {
            Random rnd = new Random();
            var ProsthVathmwn = 0m;
            for (int i = 0; i < metr; i++)
            {
                ReviewRate[i] = rnd.Next(5, 11);
                ProsthVathmwn += ReviewRate[i];
                Reviews[i] = $"Hmmm";
            }
            Rating = ProsthVathmwn / metr;
        }

    }

}
//{ { "Guardians of the galaxy","Chris Pratt", "9","2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" }, { "Guardians of the galaxy", "Chris Pratt", "9", "2000000", "50" } };
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApplication.MovieModels
{
    public class Movie
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public string Runtime { get; set; }

        public string Genre { get; set; }

        public string Writer { get; set; }

        public string Actors { get; set; }

        public string Language { get; set; }

        public string Country { get; set; }

        public double ImdbRating { get; set; }
    }
}

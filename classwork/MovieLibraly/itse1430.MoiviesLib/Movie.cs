using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itse1430.MoiviesLib
{
    public class Movie
    {
        // Fiends - data to be stored
        //Todo: Never make fields public
        public string title = "";
        public string description = "";
        public int releaseYear = 1900;
        public string rating = "";
        public bool hasSeen;
        public int runLength;


        /// <summary>
        /// Validates the movie.
        /// </summary>
        /// <returns>An error message if validation fails or empty otherwise.</returns>
        public string Validate ()
        {
            //
            var title = ""; 

            //Name is required
            if (String.IsNullOrEmpty (this.title))
                return "Title is required";

            //Release year >= 1900
            if (releaseYear < 1900)
                return "Release Year must be >= 1900";

            //Run length >= 0
            if (runLength < 0)
                return "Run Length must be >= 0";

            //Rating is required
            if (String.IsNullOrEmpty (rating))
                return "Rating is required";

            return "";

        }

        //Can new up other obects
        //private Movie originalMovie = new Movie ();

    }
}

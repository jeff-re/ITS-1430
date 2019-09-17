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

        //Can new up other obects
        //private Movie originalMovie = new Movie ();

    }
}

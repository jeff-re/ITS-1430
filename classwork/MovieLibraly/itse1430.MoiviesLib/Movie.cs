using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itse1430.MoiviesLib
{
    public class Movie

        /// <summary>Represents movie data.</summary>
        {
            /// <summary>Gets or sets the title of the movie.</summary>
            public string Title
            {
            //null coalescing
            // !String.IsNullOrEmpty(_title) ? _title : ""

            get { return _title ?? ""; }
                set { _title = value; }
            }

            /// <summary>Gets or sets the description of the movie.</summary>
            public string Description
            {
                get { return _description ?? ""; }
                set { _description = value; }
            }

            /// <summary>Gets or sets the rating of the movie.</summary>
            public string Rating
            {
                get { return _rating ?? ""; }
                set { _rating = value; }
            }

       

        public int ReleaseYear { get; set; } = 1900;

        //Full property
        /// <summary>Gets or sets the release year.</summary>
        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value; }
        //}
        public int RunLength { get; set; }

        /// <summary>Gets or sets the run length.</summary>
        //public int RunLength
        //    {
        //        get { return _runLength; }
        //        set { _runLength = value; }
        //    }


        public bool HasSeen { get; set; }
        //public bool HasSeen
        //{
        //    get { return _hasSeen; }
        //    set { _hasSeen = value; }
        //}

        //public readonly int ReleaseYearForColor = 1939;
        public const int ReleaseYearForColor = 1939;
        //public int ReleaseYearForColor { get; } = 1939;
        //private readonly int _releaseYearForColor = 1939;


        public bool IsBlackAndWhite
        {
            get { return ReleaseYear <= ReleaseYearForColor; }
            //set { }
        }

        public string TestAccessibility
        {
            get { return ""; }
            private set { }
        }



        // Fiends - data to be stored
        //Todo: Never make fields public
        private string _title = "";
        private string _description = "";
        private int _releaseYear = 1900;
        private string _rating = "";
        private bool _hasSeen;
        private int _runLength;


        /// <summary>
        /// Validates the movie.
        /// </summary>
        /// <returns>An error message if validation fails or empty otherwise.</returns>
        public string Validate ()
        {
            //
            var title = ""; 

            //Name is required
            if (String.IsNullOrEmpty (this.Title))
                return "Title is required";

            //Release year >= 1900
            if (ReleaseYear < 1900)
                return "Release Year must be >= 1900";

            //Run length >= 0
            if (RunLength < 0)
                return "Run Length must be >= 0";

            //Rating is required
            if (String.IsNullOrEmpty (Rating))
                return "Rating is required";

            return "";

        }

        //Can new up other obects
        //private Movie originalMovie = new Movie ();

    }
}

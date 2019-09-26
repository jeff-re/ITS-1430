using System;
using System.Windows.Forms;


namespace itse1430.MoiviesLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            /// <summary>Represent movie data.</summary>
            InitializeComponent ();
            Movie movie = new Movie ();
            movie.Title = "jaws";
            movie.Description = movie.Title;

        }

        private void MoviesToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm ();
            //form.ShowDialog ();

            if (form.ShowDialog () == DialogResult.OK)
                _movie = form.Movie;

            if (form.ShowDialog (this) == DialogResult.OK)
                AddMovie(form.Movie);

        }
        private Movie _movie;

        private Movie GetSelectedMovie ()
        {
            return _movie;
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            var form = new MovieForm ();

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                //TODO: Change to update
                RemoveMovie (movie);
                AddMovie (form.Movie);
            };

        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            //Confirmation
            var msg = $"Are you sure you want to delete {movie.Title}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //TODO: dELETE IT
            _movie = null;

        }

        private void OnMovieAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);

        }

        private void AddMovie ( Movie movie )
        {
            //Add to array
            for (var index = 0; index < _movies.Length; ++index)
            {
                if (_movies[index] == null)
                {
                    _movies[index] = movie;
                    return;
                };
            };
        }

        private void RemoveMovie ( Movie movie )
        {
            //Remove from array
            for (var index = 0; index < _movies.Length; ++index)
            {
                //This won't work
                if (_movies[index] == movie)
                {
                    _movies[index] = null;
                    return;
                };
            };


        }

        private Movie[] GetMovies ()
        {
            return _movies;
        }

        private Movie[] _movies = new Movie[100];
    

    private void ExitToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }
    }
}

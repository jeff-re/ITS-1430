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


        }
        private Movie _movie;

        private void OnMovieEdit ( object sender, EventArgs e )
        {

        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {

        }

        private void OnMovieAbout ( object sender, EventArgs e )
        {

        }
    }
}

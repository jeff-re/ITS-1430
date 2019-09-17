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
            movie.title = "jaws";
            movie.description = movie.title;
            
        }

        private void MoviesToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void AddToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var form = new MovieForm ();
            form.ShowDialog ();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itse1430.MoiviesLib.Host
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent ();
        }

        private void Label5_Click ( object sender, EventArgs e )
        {

        }
        public Movie Movie;

        private void BtnSave_Click ( object sender, EventArgs e )
        {
            var movie = new Movie ();
            movie.Title = _txtName.Text;
            movie.Description = txtDescription.Text;
            movie.ReleaseYear = GetAsInt32 (_txtReleaseYear);
            movie.RunLength = GetAsInt32 (_txtRunLength);
            movie.Rating = cbRating.Text;
            movie.HasSeen = chkHasSeen.Checked;

            // validate
            var message = movie.Validate ();
            if (!String.IsNullOrEmpty (message))
                return;


            //TODO: save it
            Movie = movie;

            DialogResult = DialogResult.OK;
            Close ();

        }

        private int GetAsInt32 (TextBox control)
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;
            return 0;
        }

        private void BtnCancel_Click ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }
    }
}

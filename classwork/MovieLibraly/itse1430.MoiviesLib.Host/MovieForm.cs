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

        // must be a property
        public Movie Movie { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            // call base type
            //Onload(e)
            //base.OnLoad (e);

            if (Movie != null)
            {
                _txtName.Text = Movie.Title;
                txtDescription.Text = Movie.Description;
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
                _txtRunLength.Text = Movie.RunLength.ToString();
                cbRating.Text = Movie.Rating;
                chkHasSeen.Checked = Movie.HasSeen;
            };

        }
        private void OnSave ( object sender, EventArgs e )
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

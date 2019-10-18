using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent ();
        }

        public CharacterForm ( string title ) : this ()
        {
            //Handled by ctor chaining
            //Init();
            //InitializeComponent();

            Text = title;
        }



        public Character Character { get; set; }





        protected override void OnLoad ( EventArgs e )
        {
           
            ///Init();

            //Call base type
            //OnLoad(e);
            base.OnLoad (e);
            _txtStrength.Text= "50";
            _txtIntelligence.Text =  "50";
            _txtAgility.Text= "50";
            _txtConstitution.Text =  "50";
            _txtConstitution.Text= "50";
            _txtCharisma.Text =  "50";

            if (Character != null)
            {


                _txtName.Text= Character.Name;
                cbProfession.Text= Character.Profession;
                cbRace.Text= Character.Race;
                _txtStrength.Text= Character.Strength.ToString ();
                _txtIntelligence.Text= Character.Intelligence.ToString ();
                _txtAgility.Text= Character.Agility.ToString ();
                _txtConstitution.Text= Character.Constitution.ToString ();
                _txtCharisma.Text= Character.Charisma.ToString ();
                _txtName.Text= Character.Description;

            };

            
            ValidateChildren ();
        }





        private void BtnSave_Click ( object sender, EventArgs e )
        {
            if (!ValidateChildren ())
                return;

            var character = new Character ();
            character.Name = _txtName.Text;
            character.Profession = cbProfession.Text;
            character.Race = cbRace.Text;
            character.Strength = GetAsInt32 (_txtStrength);
            character.Intelligence = GetAsInt32 (_txtIntelligence);
            character.Agility = GetAsInt32 (_txtAgility);
            character.Constitution = GetAsInt32 (_txtConstitution);
            character.Charisma = GetAsInt32 (_txtCharisma);
            character.Description = txtDescription.Text;

            //Validate
            var message = character.Validate ();
            if (!String.IsNullOrEmpty (message))
            {
                MessageBox.Show (this, message,
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            };

            //TODO: Save it
            Character = character;

            DialogResult = DialogResult.OK;
            Close ();

        }


        private int GetAsInt32 ( TextBox control )
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;

            return 0;
        }

        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            //Name is required
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Name is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            //Text is required
            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "profession is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            //Text is required
            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Race is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingAttributes ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 0 || value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Must be between 0 and 100 ");
            } else
            {
                _errors.SetError (control, "");
            }
        }





    }
}

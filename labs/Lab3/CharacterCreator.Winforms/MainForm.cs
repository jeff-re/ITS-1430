/*
 * ITSE-1430-20630: Introduction to C# Programming
 * Geoffrey kio
 *11/8/2019
 * 
 */

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
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();

        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);

            //Seed characters
            _characters = new MemoryCharacterDatabase();

            var count = _characters.GetAll ().Count ();
            if (count == 0)
                CharacterDatabaseExtensions.Seed(_characters);

            UpdateUI ();
        }

        private void onCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm ("Create New Character");

            //display error if character is not unique
            if (form.ShowDialog (this) == DialogResult.OK)
            {
                try
                {
                    _characters.Add (form.Character);
                    UpdateUI ();
                } catch (ArgumentException ex)
                {
                    MessageBox.Show (ex.Message, "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                };

            }
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            //Get selected character
            var character = GetSelectedCharacters ();
            if (character == null)
                return;

            var form = new CharacterForm ("Edit Character");
            form.Character = character;

            if (form.ShowDialog (this) != DialogResult.OK)
                return;
            try
            {
                _characters.Update (character.Id, form.Character);
                UpdateUI ();

            } catch (ArgumentException ex)
            {
                MessageBox.Show (ex.Message, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacters ();
            if (character == null)
                return;

            //delete Confirmation
            var msg = $"Are you sure you want to delete {character.Name}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //Delete it
            _characters.Delete (character.Id);
            UpdateUI ();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);

        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();

        }

        private void UpdateUI ()
        {
            var characters = _characters.GetAll ()
                                .OrderBy (c => c.Name);

            _lstCharacters.DataSource = characters.ToArray ();
        }

        private Character GetSelectedCharacters ()
        {   
            var item = _lstCharacters.SelectedItem;
           
            return item as Character;   
        }

        private ICharacterRoster _characters;

    }
}


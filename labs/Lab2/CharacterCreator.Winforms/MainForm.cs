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

            var character = new Character ();
            character.Name = "Default";
            character.Profession = "Fighter";
            character.Race = "Human";
            character.Intelligence = 70;
            character.Strength = 82;
            character.Agility = 74;
            character.Charisma = 90;
            character.Constitution = 55; 

            AddCharacter (character);
            UpdateUI ();

        }
        private void onCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm("Create New Character");
            if (form.ShowDialog (this) == DialogResult.OK)
            {
                AddCharacter (form.Character);
                UpdateUI ();

            };

        }

        private void AddCharacter ( Character character )
        {
            //Add to array
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == null)
                {
                    _characters[index] = character;
                    return;
                };
            };
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            //Get selected character
            var character = GetSelectedMovie ();
            if (character == null)
                return;
            
            var form = new CharacterForm ("Edit Character");
            form.Character = character;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                RemoveCharacter (character);
                AddCharacter (form.Character);
                UpdateUI ();

            };
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedMovie ();
            if (character == null)
                return;

            //delete Confirmation
            var msg = $"Are you sure you want to delete {character.Name}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //Delete it
            RemoveCharacter (character);
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

        private Character[] GetCharacters ()
        {
            //Filter out empty characters
            var count = 0;
            foreach (var character in _characters)
                if (character != null)
                    ++count;

            var index = 0;
            var characters = new Character[count];

            foreach (var character in _characters)
                if (character != null)
                    characters[index++] = character;

            return characters;
        }

        private void UpdateUI ()
        {
            var characters = GetCharacters ();

        
            _lstCharacters.DataSource = characters;
        }

        private Character GetSelectedMovie ()
        {
           
            var item = _lstCharacters.SelectedItem;
           

            return item as Character;
           
        }

        private void RemoveCharacter ( Character character )
        {
            //Remove from array
            for (var index = 0; index < _characters.Length; ++index)
            {
           
                if (_characters[index] == character)
                {
                    _characters[index] = null;
                    return;
                };
            };
        }

        private Character[] _characters = new Character[100];

    }

}


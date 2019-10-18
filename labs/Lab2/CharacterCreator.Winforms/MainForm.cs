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

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);

        }

        private void onCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm();
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
            //Get selected movie
            var character = GetSelectedMovie ();
            if (character == null)
                return;
            
            var form = new CharacterForm ();
            form.Character = character;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                //TODO: Change to update
                RemoveCharacter (character);
                //RemoveMovie(form.Movie);
                AddCharacter (form.Character);
                UpdateUI ();
            };
        }







        private Character[] GetCharacters ()
        {
            //Filter out empty movies
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


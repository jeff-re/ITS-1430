using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        #region properties

        public string Name
        {
            //null coalescing
            // !String.IsNullOrEmpty(_title) ? _title : ""
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        public string Profession
        {
            get { return _profession  ?? ""; }
            set { _profession  = value; }
        }

        public string Race
        {
            get { return _race  ?? ""; }
            set { _race  = value; }
        }

        public int Strength { get; set; } = 50;
        public int Intelligence { get; set; } = 50;

        public int Agility { get; set; } = 50;

        public int Constitution { get; set; } = 50;

        public int Charisma { get; set; } = 50;

        public override string ToString ()
        {
            return $"{Name} ({Strength}) ";
        }

        public string Validate ()
        {
            if (string.IsNullOrEmpty (this.Name))
                return "Name is required";

            if (Strength < 0 || Strength > 100)
                return "Strength must be between 0 and 100";

            if (Intelligence < 0 || Intelligence > 100)
                return "Intelligence must be between 0 and 100";

            if (Agility < 0 || Agility > 100)
                return "Agility must be between 0 and 100";

            if (Constitution < 0 || Constitution > 100)
                return "Constitution must be between 0 and 100";

            if (Charisma < 0 || Charisma > 100)
                return "Charisma must be between 0 and 100";

            return "";

        }



        #endregion




        #region private Members
        private string _name = "";
        private string _description = "";
        private string _profession = "";
        private string _race = "";




        #endregion
    }
}

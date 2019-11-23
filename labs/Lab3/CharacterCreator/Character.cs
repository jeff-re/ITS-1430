/*
 * ITSE-1430-20630: Introduction to C# Programming
 * Geoffrey kio
 *11/8/2019
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator
{
    public class Character : IValidatableObject
    {
        #region properties

        public int Id { get; set; }

        // Name of character
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        //Character description
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        //Character profession
        public string Profession
        {
            get { return _profession  ?? ""; }
            set { _profession  = value; }
        }

        // Character race
        public string Race
        {
            get { return _race  ?? ""; }
            set { _race  = value; }
        }

        // character attributes 
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public int Agility { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }

        // display charcter name on roster
        public override string ToString ()
        {
            return $"{Name}";
        }

        //Validate inputs
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {

            //Name is required
            if (String.IsNullOrEmpty (Name))
                yield return new ValidationResult ("Name is required");

            if (Strength < 0 || Strength > 100)
                yield return new ValidationResult ("Strength must be between 0 and 100");

            if (Intelligence < 0 || Intelligence > 100)
                yield return new ValidationResult ("Intelligence must be between 0 and 100");

            if (Agility < 0 || Agility > 100)
                yield return new ValidationResult ("Agility must be between 0 and 100");

            if (Constitution < 0 || Constitution > 100)
                yield return new ValidationResult ("Constitution must be between 0 and 100");

            if (Charisma < 0 || Charisma > 100)
                yield return new ValidationResult ("Charisma must be between 0 and 100");
        }

        #endregion private members

        #region private Members

        private string _name = "";
        private string _description = "";
        private string _profession = "";
        private string _race = "";

        #endregion
    }
}

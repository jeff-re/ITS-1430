/*
 * ITSE-1430-20630: Introduction to C# Programming
 * Geoffrey kio
 *11/8/2019
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class MemoryCharacterDatabase : CharacterDatabase
    {

        protected override Character AddCore ( Character character )
        {
            //Add character
            character.Id = ++_id;

            var newCharacter = Clone (new Character (), character);
            _characters.Add (newCharacter);

            return character;
        }

        protected override Character GetCore ( int id )
        {
            var character = FindCharacter (id);

            return character != null ? Clone (new Character (), character) : null;
        }

        protected override IEnumerable<Character> GetAllCore ()
        {
            foreach (var character in _characters)
                yield return Clone (new Character (), character);
        }

        protected override Character GetByNameCore ( string name )
        {
            foreach (var character in _characters)
                if (String.Compare (character.Name, name, true) == 0)
                    return character;

            return null;
        }

        protected override void RemoveCore ( int id )
        {
            var character = FindCharacter (id);
            if (character != null)
                _characters.Remove (character);
        }

        protected override Character UpdateCore ( int id, Character newCharacter )
        {
            var existing = FindCharacter (id);
            if (existing == null)
                return null;

            //Update existing character
            newCharacter.Id = id;
            Clone (existing, newCharacter);

            return newCharacter;
        }

        private Character Clone ( Character target, Character source )
        {
            target.Id = source.Id;
            target.Description = source.Description;
            target.Profession = source.Profession;
            target.Race = source.Race;
            target.Strength = source.Strength;
            target.Intelligence = source.Intelligence;
            target.Agility = source.Agility;
            target.Constitution = source.Constitution;
            target.Charisma = source.Charisma;
            target.Name = source.Name;

            return target;
        }

        private Character FindCharacter ( int id )
        {
            foreach (var character in _characters)
                if (character.Id == id)
                    return character;

            return null;
        }

        private List<Character> _characters = new List<Character> ();

        private int _id = 0;
    }
}

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
    public abstract class CharacterDatabase : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            //validate
            if (character == null)
                return null;

            var results = ObjectValidator.TryValidateObject (character);
            if (results.Count () > 0)
                return null;

            //Name must be unique
            var existing = GetByNameCore (character.Name);
            if (existing != null)
                throw new ArgumentException ("Movie must be unique");

            return AddCore (character);
        }

        public void Delete ( int id )
        {
            RemoveCore (id);
        }

        public Character Get ( int id )
        {
            if (id <= 0)
                return null;

            return GetCore (id);
        }

        public IEnumerable<Character> GetAll ()
               => GetAllCore ();

        public void Update ( int id, Character newCharacter )
        {
            if (id <= 0)
                return;
            if (newCharacter == null)
                return;
           
            var results = ObjectValidator.TryValidateObject (newCharacter);
            if (results.Count () > 0)
                return;

            //character must be unique
            var existing = GetByNameCore (newCharacter.Name);
            if (existing != null && existing.Id != id)
                throw new ArgumentException ("character must be unique.");

            try
            {
                UpdateCore (id, newCharacter);

            } catch (System.IO.IOException ex)
            {
                throw new Exception ("An error occurred updating the character.", ex);
            };
        }

        protected abstract Character AddCore ( Character movie );

        protected abstract Character GetCore ( int id );

        protected abstract IEnumerable<Character> GetAllCore ();

        protected abstract Character GetByNameCore ( string name );

        protected abstract void RemoveCore ( int id );

        protected abstract Character UpdateCore ( int id, Character newMovie );

    }
}

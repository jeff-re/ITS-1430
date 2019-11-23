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
    public interface ICharacterRoster
    {
        //add character
        Character Add ( Character movie );

        //delete character
        void Delete ( int id );

        Character Get ( int id );

        IEnumerable<Character> GetAll ();

        //update character
        void Update ( int id, Character newMovie );

    }
}

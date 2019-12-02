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
    public static class CharacterDatabaseExtensions
    {
        public static void Seed ( this ICharacterRoster source )
        {
            source.Add (new Character () {
                Name = "Default",
                Profession = "Fighter",
                Race = "Human",
                Intelligence = 55,
                Strength = 82,
                Agility = 74,
                Charisma = 90,
                Constitution = 55
                });
            source.Add (new Character () {
                Name = "Default 2",
                Profession = "Fighter",
                Race = "Human",
                Intelligence = 70,
                Strength = 82,
                Agility = 74,
                Charisma = 90,
                Constitution = 55
            });
        }
    }
}


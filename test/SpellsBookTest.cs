using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
    public class SpellsBookTests
    {
        [Test]
        public void LibroDeHechizosUnHechizoAtack()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            int expected = 70;
            Assert.AreEqual(book.AttackValue, expected);
            
        }

        [Test]
        public void LibroDeHechizosUnHechizoDefense()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            int expected = 70;
            Assert.AreEqual(book.DefenseValue, expected);
            
        }

        [Test]
        public void LibroDeHechizosDosHechizoAtack()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell(),new Spell() };
            int expected = 140;
            Assert.AreEqual(book.AttackValue, expected);
            
        }
        [Test]
        public void LibroDeHechizosDosHechizoDefense()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell(),new Spell() };
            int expected = 140;
            Assert.AreEqual(book.DefenseValue, expected);
            
        }
        
    }
}
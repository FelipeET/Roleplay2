using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
    public class SpellTest
    {
        [Test]
        public void DefensaValida()
        {
            IDefenseItem hechizo = new Spell();
            const int expected = 70;
            Assert.AreEqual(expected, hechizo.DefenseValue);
        }

        public void AtaqueValido()
        {
            IAttackItem hechizo = new Spell();
            const int expected = 70;
            Assert.AreEqual(expected, hechizo.AttackValue);
        }
    }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
}
using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class ArmorTest
        {
            [Test]
            public void DefensaValida()
            {
                IDefenseItem armadura = new Armor();
                const int expected = 25;
                Assert.AreEqual(expected, armadura.DefenseValue);
            }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
        }
    }
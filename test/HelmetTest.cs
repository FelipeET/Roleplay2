using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class HelmetTest
        {
            [Test]
            public void DefensaValida()
            {
                IDefenseItem casco = new Helmet();
                const int expected = 18;
                Assert.AreEqual(expected, casco.DefenseValue);
            }

        }
    }
using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class AxeTest
        {
            [Test]
            public void AtaqueValido()
            {
                IAttackItem hacha = new Axe();
                const int expected = 25;
                Assert.AreEqual(expected, hacha.AttackValue);
            }

        }
    }
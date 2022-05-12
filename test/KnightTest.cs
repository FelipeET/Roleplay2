using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //REPETIR ESTO PARA CADA PERSONAJE

    public class KnightTests
    {
      [Test]
        public void TestName()
        {
           const string expected = "elpeleador";
           Knight jon = new Knight(expected);
           Assert.AreEqual(expected, jon.Name);
        }
         
      [Test]
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Knight jon = new Knight(" ");
           Assert.AreEqual(expected, jon.Name);
        }

      [Test]
      public void TestAttackValue()
      {  
        const int expected = 20;  
        Knight jon = new Knight("Jon");
        jon.Sword = new Sword();
        Assert.AreEqual(expected, jon.AttackValue);
      }

      [Test]
      public void TestDefenseValue()
      {  
        const int expected = 39;  
        Knight jon = new Knight("Jon");
        jon.Shield = new Shield();
        jon.Armor = new Armor();
        Assert.AreEqual(expected, jon.DefenseValue);
      }

      [Test]
      public void TestAddSword()
      {
        const int expected = 20;  
        Knight jon = new Knight("Jon");
        jon.Sword = new Sword();
        Assert.AreEqual(expected, jon.AttackValue);
      }

      [Test]
      public void TestAddArmorAndShield()
      {  
        const int expected = 39;  
        Knight jon = new Knight("Jon");
        jon.Shield = new Shield();
        jon.Armor = new Armor();
        Assert.AreEqual(expected, jon.DefenseValue);
      }

       [Test]
        public void TestReciveAttack()
        {  
         const int expected = 99; 
         Knight jon = new Knight("Jon");
         jon.Shield = new Shield();
         jon.Armor = new Armor();
         jon.ReceiveAttack(40);
         Assert.AreEqual(expected, jon.Health);
        }

       [Test]
        public void TestCure()
        {
         const int expected = 100; 
         Knight jon = new Knight("Jon");
         jon.Shield = new Shield();
         jon.Armor = new Armor();
         jon.ReceiveAttack(40);
         jon.Cure();
         Assert.AreEqual(expected, jon.Health);
        }
    }
}
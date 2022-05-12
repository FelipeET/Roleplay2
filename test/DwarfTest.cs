using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //REPETIR ESTO PARA CADA PERSONAJE

    public class DwarfTests
    {
      [Test]
        public void TestName()
        {
           const string expected = "Elenano";
           Dwarf gimli = new Dwarf(expected);
           Assert.AreEqual(expected, gimli.Name);
        }
         
      [Test]
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Dwarf gimli = new Dwarf(" ");
           Assert.AreEqual(expected, gimli.Name);
        }

      [Test]
      public void TestAttackValue()
      {  
        const int expected = 25;  
        Dwarf gimli = new Dwarf("Gimli");
        gimli.Axe = new Axe();
        Assert.AreEqual(expected, (gimli.AttackValue));
      }

      [Test]
      public void TestDefenseValue()
      {  
        const int expected = 32;
        Dwarf gimli = new Dwarf("Gimli");
        gimli.Helmet = new Helmet();
        gimli.Shield = new Shield();  
        Assert.AreEqual(expected, (gimli.DefenseValue));
      }

      [Test]
      public void TestAddAxe()
      {
        const int expected = 25;  
        Dwarf gimli = new Dwarf("Gimli");
        gimli.Axe = new Axe();
        Assert.AreEqual(expected, (gimli.AttackValue));
      }

      [Test]
      public void TestAddHelmetAndShield()
      {  
         const int expected = 32;
         Dwarf gimli = new Dwarf("Gimli");
        gimli.Helmet = new Helmet();
        gimli.Shield = new Shield();  
        Assert.AreEqual(expected, (gimli.DefenseValue));
      }

       [Test]
        public void TestReciveAttack()
        {  
         const int expected = 99;
         Dwarf gimli = new Dwarf("Gimli");
         gimli.Helmet = new Helmet();
         gimli.Shield = new Shield();  
         gimli.ReceiveAttack(33);
         Assert.AreEqual(expected, (gimli.Health));
        }

       [Test]
        public void TestCure()
        {
         const int expected = 100;
         Dwarf gimli = new Dwarf("Gimli");
         gimli.Helmet = new Helmet();
         gimli.Shield = new Shield();  
         gimli.ReceiveAttack(33);
         gimli.Cure();
         Assert.AreEqual(expected, (gimli.Health));
        }
    }
}
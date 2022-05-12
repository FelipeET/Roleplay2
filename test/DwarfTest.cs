using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //REPETIR ESTO PARA CADA PERSONAJE

    public class DwarfTests
    {
      [Test]
       //probamos el atributo name en la clase Dwarf
        public void TestName()
        {
           const string expected = "Elenano";
           Dwarf gimli = new Dwarf(expected);
           Assert.AreEqual(expected, gimli.Name);
        }
         
      [Test]
       //probamos el atributo name en la clase Dwarf
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Dwarf gimli = new Dwarf(" ");
           Assert.AreEqual(expected, gimli.Name);
        }

      [Test]
       //probamos el atributo AttackValue en la clase Dwarf
      public void TestAttackValue()
      {  
        const int expected = 25;  
        Dwarf gimli = new Dwarf("Gimli");
        gimli.Axe = new Axe();
        Assert.AreEqual(expected, (gimli.AttackValue));
      }

      [Test]
       //probamos el atributo DefenseValue en la clase Dwarf
      public void TestDefenseValue()
      {  
        const int expected = 32;
        Dwarf gimli = new Dwarf("Gimli");
        gimli.Helmet = new Helmet();
        gimli.Shield = new Shield();  
        Assert.AreEqual(expected, (gimli.DefenseValue));
      }

      [Test]
       //probamos el atributo Axe en la clase Dwarf
      public void TestAddAxe()
      {
        const int expected = 25;  
        Dwarf gimli = new Dwarf("Gimli");
        gimli.Axe = new Axe();
        Assert.AreEqual(expected, (gimli.AttackValue));
      }

      [Test]
       //probamos los atributis Helmet y Shield en la clase Dwarf
      public void TestAddHelmetAndShield()
      {  
         const int expected = 32;
         Dwarf gimli = new Dwarf("Gimli");
        gimli.Helmet = new Helmet();
        gimli.Shield = new Shield();  
        Assert.AreEqual(expected, (gimli.DefenseValue));
      }

       [Test]
       //probamos el metodo ReciveAttack en la clase Dwarf
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
       //probamos el metodo Cure en la clase Dwarf
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

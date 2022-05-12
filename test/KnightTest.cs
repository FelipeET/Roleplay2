using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //REPETIR ESTO PARA CADA PERSONAJE

    public class KnightTests
    {
      [Test]
       //probamos el atributo Name en la clase Kight
        public void TestName()
        {
           const string expected = "elpeleador";
           Knight jon = new Knight(expected);
           Assert.AreEqual(expected, jon.Name);
        }
         
      [Test]
       ////probamos el atributo Name en la clase Kight
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Knight jon = new Knight(" ");
           Assert.AreEqual(expected, jon.Name);
        }

      [Test]
       //probamos el atributo AttackValue en la clase Kight
      public void TestAttackValue()
      {  
        const int expected = 20;  
        Knight jon = new Knight("Jon");
        jon.Sword = new Sword();
        Assert.AreEqual(expected, jon.AttackValue);
      }

      [Test]
       //probamos el atributo DefenseValue en la clase Kight
      public void TestDefenseValue()
      {  
        const int expected = 39;  
        Knight jon = new Knight("Jon");
        jon.Shield = new Shield();
        jon.Armor = new Armor();
        Assert.AreEqual(expected, jon.DefenseValue);
      }

      [Test]
       //probamos el atributo Sword en la clase Kight
      public void TestAddSword()
      {
        const int expected = 20;  
        Knight jon = new Knight("Jon");
        jon.Sword = new Sword();
        Assert.AreEqual(expected, jon.AttackValue);
      }

      [Test]
       //probamos los atributos Armor y Shield en la clase Kight
      public void TestAddArmorAndShield()
      {  
        const int expected = 39;  
        Knight jon = new Knight("Jon");
        jon.Shield = new Shield();
        jon.Armor = new Armor();
        Assert.AreEqual(expected, jon.DefenseValue);
      }

       [Test]
       //probamos el metodo ReciveAttack en la clase Kight
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
       //probamos el metodo Cure en la clase Kight
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

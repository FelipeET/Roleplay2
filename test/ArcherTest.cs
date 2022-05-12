using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //REPETIR ESTO PARA CADA PERSONAJE

    public class ArcherTests
    {
      [Test]
       //probamos el atributo name de la clase Archer
        public void TestName()
        {
           const string expected = "tiraflecha";
           Archer robin = new Archer(expected);
           Assert.AreEqual(expected, robin.Name);
        }
         
      [Test]
       //probamos si el nombre puede ser un espacio en blanco
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Archer robin = new Archer(" ");
           Assert.AreEqual(expected, robin.Name);
        }

      [Test]
       //probamos el atributo AttackValue de la clase Archer
      public void TestAttackValue()
      {  
        const int expected = 15;  
        Archer robin = new Archer("Robin");
        robin.Bow = new Bow();
        Assert.AreEqual(expected, (robin.AttackValue));
      }

      [Test]
       //probamos el atributo DefenseValue de la clase Archer
      public void TestDefenseValue()
      {  
        const int expected = 18;
        Archer robin = new Archer("Robin");
        robin.Helmet = new Helmet();  
        Assert.AreEqual(expected, (robin.DefenseValue));
      }

      [Test]
       //probamos el atributo Bow de la clase Archer
      public void TestAddBow()
      {
        const int expected = 15;  
        Archer robin = new Archer("Robin");
        robin.Bow = new Bow();
        Assert.AreEqual(expected, (robin.AttackValue));
      }

      [Test]
       //probamos el atributo Helmet de la clase Archer
      public void TestAddHelmet()
      {  
        const int expected = 18;
        Archer robin = new Archer("Robin");
        robin.Helmet = new Helmet();  
        Assert.AreEqual(expected, (robin.DefenseValue));
      }

       [Test]
       //probamos el metodo ReciveAttack de la clase Archer
        public void TestReciveAttack()
        {  
         const int expected = 99;
         Archer robin = new Archer("Robin");
         robin.Helmet = new Helmet();  
         robin.ReceiveAttack(19);
         Assert.AreEqual(expected, (robin.Health));
        }

       [Test]
       //probamos el metodo Cure de la clase Archer
        public void TestCure()
        {
         const int expected = 100;
         Archer robin = new Archer("Robin");
         robin.Helmet = new Helmet();  
         robin.ReceiveAttack(19);
         robin.Cure();
         Assert.AreEqual(expected, (robin.Health));
        }
    }
}

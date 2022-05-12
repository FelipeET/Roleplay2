using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //REPETIR ESTO PARA CADA PERSONAJE

    public class WizTests
    {
      [Test]
       //probamos el atributo Name de la clase Wizard
        public void TestName()
        {
           const string expected = "Gandalf";
           Wizard gandalf = new Wizard(expected);
           Assert.AreEqual(expected, gandalf.Name);
        }
         
      [Test]
       //probamos el atributo Name de la clase Wizard
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Wizard gandalf = new Wizard(" ");
           Assert.AreEqual(expected, gandalf.Name);
        }

      [Test]
       //probamos el atributo AttackValue de la clase Wizard
      public void TestAttackValue()
      {  
         const int expected = 170;  
         SpellsBook book = new SpellsBook();
         book.Spells = new Spell[]{ new Spell() };
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         gandalf.SpellsBook = book;
         Assert.AreEqual(expected, (gandalf.AttackValue));
      }

      [Test]
       //probamos el atributo DefenseValue de la clase Wizard
      public void TestDefenseValue()
      {  
          const int expected = 170;  
         SpellsBook book = new SpellsBook();
         book.Spells = new Spell[]{ new Spell() };
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         gandalf.SpellsBook = book;
         Assert.AreEqual(expected, (gandalf.DefenseValue));
      }

      [Test]
       //probamos el atributo Staff de la clase Wizard
      public void TestAddStaff()
      {  
         const int expected = 170;  
         SpellsBook book = new SpellsBook();
         book.Spells = new Spell[]{ new Spell() };
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         gandalf.SpellsBook = book;
         Assert.AreEqual(expected, (gandalf.AttackValue));
      }

      [Test]
       //probamos los atributos Book y Spell de la clase Wizard
      public void TestAddBookAndSpell()
      {  
         const int expected = 70;  
         SpellsBook book = new SpellsBook();
         book.Spells = new Spell[]{ new Spell() };
         Assert.AreEqual(expected, book.AttackValue);
      }

       [Test]
       //probamos el metodo ReciveAttack de la clase Wizard
        public void TestReciveAttack()
        {
         const int expected = 90;  
         SpellsBook book = new SpellsBook();
         book.Spells = new Spell[]{ new Spell() };
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         gandalf.SpellsBook = book;
         gandalf.ReceiveAttack(180);
         Assert.AreEqual(expected, (gandalf.Health));
        }

       [Test]
        public void TestCure()
        //probamos el metodo Cure de la clase Wizard
        {
         const int expected = 100;  
         SpellsBook book = new SpellsBook();
         book.Spells = new Spell[]{ new Spell() };
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         gandalf.SpellsBook = book;
         gandalf.ReceiveAttack(170);
         gandalf.Cure();
         Assert.AreEqual(expected, (gandalf.Health));
        }
    }
}

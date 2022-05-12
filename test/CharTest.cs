using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //Salta un error al intentar correr los test, no pudimos solucionarlo, 
   //si puede explicarnos en la retroalimentación de la terea en que estamos fallando le agradezco
   //ERROR:
   //El nombre del tipo o del espacio de nombres 'Spell' no se encontró 
   //(¿falta una directiva using o una referencia de ensamblado?

   //Repetir test para cada Personaje o usar la interface en los tests?

    public class CharTests
    {
      [Test]
        public void TestName()
        {
           const string expected = "Gandalf";
           Wizard gandalf = new Wizard(expected);
           Assert.AreEqual(expected, gandalf.Name);
        }
         
      [Test]
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Wizard gandalf = new Wizard(" ");
           Assert.AreEqual(expected, gandalf.Name);
        }

      [Test]
      public void TestAttackValue()
      {  
         const int expected = 100;  
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         Assert.AreEqual(expected, gandalf.AttackValue);
      }

      [Test]
      public void TestDefenseValue()
      {  
         const int expected = 100;  
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         Assert.AreEqual(expected, gandalf.DefenseValue);
      }

      [Test]
      public void TestAddStaff()
      {  
         const int expected = 200;  
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.Staff = new Staff();
         Assert.AreEqual(expected, (gandalf.AttackValue + gandalf.DefenseValue));
      }

      [Test]
      public void TestAddBookAndSpell()
      {  
         const int expected = 70;  
         SpellsBook book = new SpellsBook();
         book.Spells = new Spell[]{ new Spell() };
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.SpellsBook = book;
         Assert.AreEqual(expected, gandalf.AttackValue);
      }

       [Test]
        public void TestReciveAttack()
        {
           const string expected = "50";
           Wizard gandalf = new Wizard("Gandalf");
           gandalf.ReceiveAttack(50);
           Assert.AreEqual(expected, gandalf.Health);
        }

       [Test]
        public void TestCure()
        {
           const int expected = 100;
           Wizard gandalf = new Wizard("Gandalf");
           gandalf.ReceiveAttack(50);
           gandalf.Cure();
           Assert.AreEqual(expected, gandalf.Health);
        }
    }
}

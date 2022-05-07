namespace RoleplayGame
{
    public interface ICharacter
    {
        public void Cure();
        public void ReceiveAttack(int power);
        public int Health {get;}
        public int AttackValue {get;}
        public int DefenseValue {get;}
    }
}
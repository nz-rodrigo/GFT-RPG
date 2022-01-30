namespace GFT_RPG.scr.entities
{
    public class Wizard : Hero
    {
        public Wizard(int attack, int defense, int life) : base(attack, defense, life)
        { }
        public override int Attack()
        {
            return base.Attack();
        }
        public override int Defense()
        {
            return base.Defense();
        }

    }
}
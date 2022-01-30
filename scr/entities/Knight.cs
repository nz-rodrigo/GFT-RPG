namespace GFT_RPG.scr.entities
{
    public class Knight : Hero
    {
        public Knight(int attack, int defense, int life) : base(attack, defense, life)
        {

        }
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
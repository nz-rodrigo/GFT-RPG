namespace GFT_RPG.scr.entities
{
    public abstract class Hero
    {
        protected int attack;
        protected int defense;
        protected int life;
        public Hero(int attack, int defense, int life)
        {
            this.attack = attack;
            this.defense = defense;
            this.life = life;
        }

        public virtual int Attack()
        {
            return (1);
        }
        public virtual int Defense()
        {
            return (1);
        }
        public int GetAttack => attack;
        public int GetDefense => defense;
        public int GetLife => life;
    }
}
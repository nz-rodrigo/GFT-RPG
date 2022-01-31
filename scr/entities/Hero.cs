using System;
namespace GFT_RPG.scr.entities
{
    public class Hero
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

        public Hero() { }

        public virtual int Attack()
        {
            Random random = new Random();
            int power = random.Next(1, 6);

            if (power == 5)
            {
                Console.WriteLine("Ataque com golpe especial!");
                return this.attack + 2;
            }
            else
            {
                Console.WriteLine("Ataque");
                return this.attack;
            }
        }
        public virtual void Defense()
        {
            Random random = new Random();
            int power = random.Next(1, 5);

            if (this.life < 10)
            {
                if (power == 4)
                {
                    Console.WriteLine("Defesa com recuperação de vida +4");
                    this.life += 4;
                }
                else
                {
                    Console.WriteLine("Defesa +2");
                    this.life += 2;
                }
            }
            else
            {
                Console.WriteLine("Defesa +1");
                this.life++;
            }

        }
        public int GetAttack => attack;
        public int GetDefense => defense;
        public int Life
        {
            get => life;
            set => life = value;
        }
    }
}
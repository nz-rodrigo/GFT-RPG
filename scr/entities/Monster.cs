using System;
namespace GFT_RPG.scr.entities
{
    public class Monster : Hero
    {
        public Monster(int attack, int defense, int life) : base(attack, defense, life)
        { }
        public override int Attack()
        {
            Random random = new Random();
            int power = random.Next(1, 6);

            if (power == 5)
            {
                Console.WriteLine("Ataque com golpe especial!");
                return this.attack + 4;
            }
            else
            {
                Console.Write("Ataque ");
                return this.attack;
            }
        }
        public override void Defense()
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
    }
}

using System;
namespace GFT_RPG.scr.entities
{
    public class Knight : Hero
    {
        public Knight(int attack, int defense, int life) : base(attack, defense, life)
        { }
        public override int Attack()
        {
            Random random = new Random();
            int power = random.Next(1, 4);

            if (power == 3)
            {
                Console.WriteLine("Ataque com golpe especial!");
                return this.attack + 3;
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
                    Console.WriteLine("Defesa com recuperação de vida +6");
                    this.life += 6;
                }
                else
                {
                    Console.WriteLine("Defesa +3");
                    this.life += 3;
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
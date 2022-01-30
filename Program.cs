using System;
using GFT_RPG.scr.entities;

namespace GFT_RPG
{
    class Program
    {
        static int choose = 0;
        static void Main(string[] args)
        {
            Knight knight = new Knight(3, 6, 10);
            Monster monster = new Monster(4, 4, 11);
            Paladin paladin = new Paladin(4, 3, 13);
            Wizard wizard = new Wizard(6, 2, 12);

            MenuHero(knight, monster, paladin, wizard);
            Console.ReadKey();

        }
        static void MenuHero(Knight knight, Monster monster, Paladin paladin, Wizard wizard)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("MENU DE PERSONAGENS");

                Console.WriteLine("\nCavaleiro Código 1");
                System.Console.WriteLine($"Ataque: { knight.GetAttack }");
                System.Console.WriteLine($"Defesa: { knight.GetDefense }");
                System.Console.WriteLine($"Vida: { knight.GetLife }");

                Console.WriteLine("\nMonstro Código 2");
                System.Console.WriteLine($"Ataque: { monster.GetAttack }");
                System.Console.WriteLine($"Defesa: { monster.GetDefense }");
                System.Console.WriteLine($"Vida: { monster.GetLife }");

                Console.WriteLine("\nPaladino Código 3");
                System.Console.WriteLine($"Ataque: { paladin.GetAttack }");
                System.Console.WriteLine($"Defesa: { paladin.GetDefense }");
                System.Console.WriteLine($"Vida: { paladin.GetLife }");

                Console.WriteLine("\nMago Código 4");
                System.Console.WriteLine($"Ataque: { wizard.GetAttack }");
                System.Console.WriteLine($"Defesa: { wizard.GetDefense }");
                System.Console.WriteLine($"Vida: { wizard.GetLife }");

                System.Console.WriteLine("Sair Código 5");
                choose = int.Parse(Console.ReadLine());

            } while (choose < 1 || choose > 5);

            if (choose == 5)
                System.Console.WriteLine("Você saiu do jogo");

            else
            {
                System.Console.Write("\nSeu Personagem");
                if (choose == 1)
                    System.Console.WriteLine("Cavaleiro");
                else if (choose == 2)
                    System.Console.WriteLine("Monstro");
                else if (choose == 3)
                    System.Console.WriteLine("Paladino");
                else if (choose == 4)
                    System.Console.WriteLine("Mago");
            }



        }

    }
}

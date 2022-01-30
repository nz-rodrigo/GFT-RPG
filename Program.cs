using System;
using GFT_RPG.scr.entities;

namespace GFT_RPG
{
    class Program
    {
        static int choosePlayer = 0;
        static int chooseCPU = 0;
        static void Main(string[] args)
        {
            MenuHero();

            if (choosePlayer != 5)
            {
                Combat();
            }
            Console.ReadKey();
        }
        static void MenuHero()
        {
            Knight knight = new Knight(3, 6, 10);
            Monster monster = new Monster(4, 4, 11);
            Paladin paladin = new Paladin(4, 3, 13);
            Wizard wizard = new Wizard(6, 2, 12);
            do
            {
                Console.Clear();
                Console.WriteLine("MENU DE PERSONAGENS");

                Console.WriteLine("\nCavaleiro Código 1");
                Console.WriteLine($"Ataque: { knight.GetAttack }");
                Console.WriteLine($"Defesa: { knight.GetDefense }");
                Console.WriteLine($"Vida: { knight.GetLife }");

                Console.WriteLine("\nMonstro Código 2");
                Console.WriteLine($"Ataque: { monster.GetAttack }");
                Console.WriteLine($"Defesa: { monster.GetDefense }");
                Console.WriteLine($"Vida: { monster.GetLife }");

                Console.WriteLine("\nPaladino Código 3");
                Console.WriteLine($"Ataque: { paladin.GetAttack }");
                Console.WriteLine($"Defesa: { paladin.GetDefense }");
                Console.WriteLine($"Vida: { paladin.GetLife }");

                Console.WriteLine("\nMago Código 4");
                Console.WriteLine($"Ataque: { wizard.GetAttack }");
                Console.WriteLine($"Defesa: { wizard.GetDefense }");
                Console.WriteLine($"Vida: { wizard.GetLife }");

                Console.WriteLine("Sair Código 5");
                choosePlayer = int.Parse(Console.ReadLine());

            } while (choosePlayer < 1 || choosePlayer > 5);

            if (choosePlayer == 5)
                Console.WriteLine("Você saiu do jogo");

            else
            {
                Console.Clear();
                Console.Write("\nJogador Personagem: ");
                if (choosePlayer == 1)
                    Console.WriteLine("Cavaleiro");
                else if (choosePlayer == 2)
                    Console.WriteLine("Monstro");
                else if (choosePlayer == 3)
                    Console.WriteLine("Paladino");
                else if (choosePlayer == 4)
                    Console.WriteLine("Mago");

                Random random = new Random();
                chooseCPU = random.Next(1, 5);

                Console.Write("       --VS--   ");
                Console.Write("\nCPU Personagem: ");

                if (chooseCPU == 1)
                    Console.WriteLine("Cavaleiro");
                else if (chooseCPU == 2)
                    Console.WriteLine("Monstro");
                else if (chooseCPU == 3)
                    Console.WriteLine("Paladino");
                else if (chooseCPU == 4)
                    Console.WriteLine("Mago");
            }
        }
        static void Combat()
        {
            Hero player = new Hero();
            Hero cpu = new Hero();

            if (choosePlayer == 1)
            {
                player = new Knight(3, 6, 10);
            }
            else if (choosePlayer == 2)
            {
                player = new Monster(4, 4, 11);
            }
            else if (choosePlayer == 3)
            {
                player = new Paladin(4, 3, 13);
            }
            else if (choosePlayer == 4)
            {
                player = new Wizard(6, 2, 12);
            }

            if (chooseCPU == 1)
            {
                cpu = new Knight(3, 6, 10);
            }
            else if (chooseCPU == 2)
            {
                cpu = new Monster(4, 4, 11);
            }
            else if (chooseCPU == 3)
            {
                cpu = new Paladin(4, 3, 13);
            }
            else if (chooseCPU == 4)
            {
                cpu = new Wizard(6, 2, 12);
            }

            int action;
            bool turn = true;
            Random random = new Random();
            int actionCpu;

            while (player.GetLife != 0 || cpu.GetLife != 0)
            {
                // Console.WriteLine(player.GetLife);
                // Console.WriteLine(cpu.GetLife);
                Console.Clear();
                Console.WriteLine($"Pontos de vida: {player.GetLife}");
                Console.WriteLine($"Pontos de vida: {cpu.GetLife}");

                if (turn == true)
                {
                    do
                    {
                        Console.WriteLine("\nEscolha a ação:");
                        Console.WriteLine("1 - Ataque");
                        Console.WriteLine("2 - Defesa");
                        action = int.Parse(Console.ReadLine());
                    } while (action < 1 || action > 2);

                    Console.Clear();

                    switch (action)
                    {
                        case 1:
                            // player.Attack();
                            Console.WriteLine("Ataque do jogador");
                            break;
                        case 2:
                            // player.Defense();
                            Console.WriteLine("Defesa do jogador");
                            break;
                    }
                    turn = false;
                }
                else
                {
                    actionCpu = random.Next(1, 3);
                    switch (actionCpu)
                    {
                        case 1:
                            // player.Attack();
                            Console.WriteLine("Ataque da máquina");
                            break;
                        case 2:
                            // player.Defense();
                            Console.WriteLine("Defesa da máquina");
                            break;
                    }
                    turn = true;
                }
                Console.ReadLine();

            }
        }
    }
}

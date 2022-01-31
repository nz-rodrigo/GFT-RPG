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
            Knight knight = new Knight(3, 6, 20);
            Monster monster = new Monster(4, 4, 21);
            Paladin paladin = new Paladin(4, 3, 23);
            Wizard wizard = new Wizard(5, 3, 20);
            do
            {
                Console.Clear();
                Console.WriteLine("MENU DE PERSONAGENS");

                Console.WriteLine("\nCavaleiro Código 1");
                Console.WriteLine($"Ataque: { knight.GetAttack }");
                Console.WriteLine($"Defesa: { knight.GetDefense }");
                Console.WriteLine($"Vida: { knight.Life }");

                Console.WriteLine("\nMonstro Código 2");
                Console.WriteLine($"Ataque: { monster.GetAttack }");
                Console.WriteLine($"Defesa: { monster.GetDefense }");
                Console.WriteLine($"Vida: { monster.Life }");

                Console.WriteLine("\nPaladino Código 3");
                Console.WriteLine($"Ataque: { paladin.GetAttack }");
                Console.WriteLine($"Defesa: { paladin.GetDefense }");
                Console.WriteLine($"Vida: { paladin.Life }");

                Console.WriteLine("\nMago Código 4");
                Console.WriteLine($"Ataque: { wizard.GetAttack }");
                Console.WriteLine($"Defesa: { wizard.GetDefense }");
                Console.WriteLine($"Vida: { wizard.Life }");

                Console.WriteLine("Sair Código 5");
                choosePlayer = int.Parse(Console.ReadLine());

            } while (choosePlayer < 1 || choosePlayer > 5);

            if (choosePlayer == 5)
                Console.WriteLine("Você saiu do jogo");

            else
            {
                Console.Clear();
                Console.Write("\nJogador: ");
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

                Console.Write("    --VS--   ");
                Console.Write("\nCPU: ");

                if (chooseCPU == 1)
                    Console.WriteLine("Cavaleiro");
                else if (chooseCPU == 2)
                    Console.WriteLine("Monstro");
                else if (chooseCPU == 3)
                    Console.WriteLine("Paladino");
                else if (chooseCPU == 4)
                    Console.WriteLine("Mago");
            }
            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();
        }
        static void Combat()
        {
            Hero player = new Hero();
            Hero cpu = new Hero();

            if (choosePlayer == 1)
            {
                player = new Knight(3, 6, 20);
            }
            else if (choosePlayer == 2)
            {
                player = new Monster(4, 4, 21);
            }
            else if (choosePlayer == 3)
            {
                player = new Paladin(4, 3, 23);
            }
            else if (choosePlayer == 4)
            {
                player = new Wizard(6, 3, 20);
            }

            if (chooseCPU == 1)
            {
                cpu = new Knight(3, 6, 22);
            }
            else if (chooseCPU == 2)
            {
                cpu = new Monster(4, 4, 23);
            }
            else if (chooseCPU == 3)
            {
                cpu = new Paladin(4, 3, 25);
            }
            else if (chooseCPU == 4)
            {
                cpu = new Wizard(6, 3, 22);
            }

            int action;
            bool turn = true;
            Random random = new Random();
            int actionCpu;
            int dano;

            while (player.Life >= 0 && cpu.Life >= 0)
            {
                Console.Clear();
                Console.WriteLine($"Pontos de vida Jogador: {player.Life}");
                Console.WriteLine($"Pontos de vida CPU: {cpu.Life}");

                if (turn == true)
                {
                    Console.WriteLine("\n> Turno do Jogador");
                    do
                    {
                        Console.WriteLine("\nEscolha a ação:");
                        Console.WriteLine("1 - Ataque");
                        Console.WriteLine("2 - Defesa");
                        action = int.Parse(Console.ReadLine());
                    } while (action < 1 || action > 2);

                    switch (action)
                    {
                        case 1:
                            dano = player.Attack();
                            Console.WriteLine($"Dano {dano}");
                            cpu.Life -= dano;
                            break;
                        case 2:
                            player.Defense();
                            break;
                    }
                    turn = false;
                }
                else
                {
                    Console.WriteLine("\n> Turno da CPU");
                    Console.WriteLine();
                    actionCpu = random.Next(1, 3);
                    switch (actionCpu)
                    {
                        case 1:
                            dano = cpu.Attack();
                            Console.WriteLine($"Dano {dano}");
                            player.Life -= dano;
                            break;
                        case 2:
                            cpu.Defense();
                            break;
                    }
                    turn = true;
                }
                Console.WriteLine("\nDigite uma tecla para continuar");
                Console.ReadLine();
            }

            if (player.Life > cpu.Life)
                Console.WriteLine("\nJOGADOR VENCEU!!!");
            else
                Console.WriteLine("\nJOGADOR FOI DERROTADO");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;

namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to \"WordOfTanks\"!");
            Thread.Sleep(1000);
            Console.Clear();
            Tank[] t_34 = new Tank[5];
            Tank[] pantera = new Tank[5];
            Console.WriteLine("5 Tanks \"T-34\" vs 5 Tanks \"Pantera\"");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i < 10 / 2)
                {
                    Console.Write("Enter name for Tank T-34: ");
                    t_34[i] = new Tank(Console.ReadLine().ToString());
                    Console.WriteLine($"Property {t_34[i].Name}: Ammunition: {t_34[i].Ammunition}%  Armour: {t_34[i].Armour}%  Mobility: {t_34[i].Mobility}%");
                    Console.WriteLine();
                    continue;
                }
                Console.Write("Enter name for Tank Pantera: ");
                pantera[i - 10 / 2] = new Tank(Console.ReadLine().ToString());
                Console.WriteLine($"Property {pantera[i - 10 / 2].Name}: Ammunition: {pantera[i - 10 / 2].Ammunition}%  Armour: {pantera[i - 10 / 2].Armour}%  Mobility: {pantera[i - 10 / 2].Mobility}%");
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();
            int winner = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{t_34[i].Name} vs {pantera[i].Name}");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, i);
                switch (t_34[i] * pantera[i])
                {
                    case 3:
                    case 2:
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{t_34[i].Name}");
                        Console.SetCursorPosition(t_34[i].Name.Length + 4, i);
                        Console.ForegroundColor = ConsoleColor.Red;
                        winner++;
                        break;
                    case -3:
                    case -2:
                    case -1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{t_34[i].Name}");
                        Console.SetCursorPosition(t_34[i].Name.Length + 4, i);
                        Console.ForegroundColor = ConsoleColor.Green;
                        winner--;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{t_34[i].Name}");
                        Console.SetCursorPosition(t_34[i].Name.Length + 4, i);
                        break;
                }
                Console.WriteLine($"{pantera[i].Name}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (0 < winner)
            {
                Console.WriteLine("Winners Tanks \"T-34\"!!!");
            }
            else if (0 > winner)
            {
                Console.WriteLine("Winners Tanks \"Pantera\"!!!");
            }
            else
            {
                Console.WriteLine("Draw.");
            }
            Console.Write("Press anything..");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Thanks for play");
            Thread.Sleep(1000);
        }
    }
}
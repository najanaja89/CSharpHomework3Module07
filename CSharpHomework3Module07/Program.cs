using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MyClassLib.WordOfTanks;

namespace CSharpHomework3Module07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int countPantera = 0;
            int countT34 = 0;
            int side = 1;
            string menu = "";
            int size = 5;
            Console.WriteLine("Press 1 to start Tank Game");
            Console.WriteLine("Press any key to exit");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                Tank[] T34 = new Tank[size];
                Tank[] Pantera = new Tank[size];

                Console.WriteLine();
                Console.WriteLine("Calculating Tanks Parameters. Please wait");
                for (int i = 0; i < T34.Length; i++)
                {
                    T34[i] = new Tank("T34 " + (i + 1));
                    Thread.Sleep(rand.Next(850, 950));
                    Console.Write('*');
                    Console.Write(' ');
                }
                for (int i = 0; i < Pantera.Length; i++)
                {
                    Pantera[i] = new Tank("Pantera " + (i + 1));
                    Thread.Sleep(rand.Next(600, 800));
                    Console.Write('*');
                    Console.Write(' ');
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choose your side: ");
                Console.WriteLine("1 - T34 ");
                Console.WriteLine("2 - Pantera ");
                Console.WriteLine("Any key for random ");
                string menuSide = Console.ReadLine();
                if (menuSide == "1")
                {
                    side = 1;
                }
                else if (menuSide == "2")
                {
                    side = 2;
                }
                else
                {
                    side = rand.Next(1, 3);
                    Console.WriteLine("Your side is " + side);
                }
                Console.WriteLine("Loading");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write('*');
                    Console.Write(' ');
                    Thread.Sleep(350);
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < size; i++)
                {
                    string result = T34[i] * Pantera[i];
                    Console.WriteLine(result);
                    Console.WriteLine();
                    if (result.Contains("T34"))
                    {
                        countT34++;
                    }
                    else if (result.Contains("Pantera"))
                    {
                        countPantera++;
                    }
                }
                Console.WriteLine();

                if (side == 1 && countT34 > countPantera)
                {
                    Console.WriteLine("You Win! For Soviet Union!");
                }
                else if (side == 2 && countT34 < countPantera)
                {
                    Console.WriteLine("You Win! Hail Hydra!");
                }
                else if ((side == 1 || side == 2) && countT34 == countPantera)
                {
                    Console.WriteLine("Draw!");

                }
                else Console.WriteLine("You Lose!");

            }

            else Environment.Exit(0);

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* Number Guesing Game */
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // The number to gues, generate randomly between 0 and 100
            int guesNumber = r.Next(0, 100);
            bool win = false;

            do {
                Console.WriteLine("Gues a number inbetween 0 and 100....");
                string gues = Console.ReadLine();

                // Try to converted to user input to a int if not possible re run the loop
                try{
                    int guesConv = int.Parse(gues);

                    if (guesConv>guesNumber) {
                        Console.WriteLine("To High, Gues lower......");
                    }
                    else if (guesConv<guesNumber) {
                        Console.WriteLine("To Low, Gues higher......");
                    }
                    else {
                        Console.WriteLine("You found the number !!!");
                        win=true;
                    }
                    Console.WriteLine();
                }
                catch {
                    continue;
                }
            } while (win==false);

            Console.WriteLine("Thank you for playing the game");
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();

        }
    }
}

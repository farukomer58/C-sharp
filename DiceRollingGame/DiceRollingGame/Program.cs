using System;

namespace DiceRollingGame {
    class Program {
        static void Main(string[] args) {

            Random random = new Random();
            // Roll three dices
            int dice1 = random.Next(1, 7);
            Console.Write($"Dice1: {dice1}");
            int dice2 = random.Next(1, 7);
            Console.Write($" - Dice2: {dice2}");
            int dice3 = random.Next(1, 7);
            Console.Write($" - Dice3: {dice3} \n");

            // Total count of the dices rolled
            int total = dice1+dice2+dice3;

            // If rolled 3 dices same back to back
            if ((dice1==dice2)&&(dice2==dice3)) {
                    
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total+=6;
            }
            else if (dice1==dice2||dice2==dice3||dice3==dice1) {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total+=2;
            }

            if (total>=15) {
                Console.WriteLine($"You Win - total score: {total}");
            }
            else {
                Console.WriteLine($"You LOSE - total score: {total}");
            }

            /*
               This code reverses a message, counts the number of times 
               a particular character appears, then prints the results
               to the console window.
             */
            /*            string originalMessage = "The quick brown fox jumps over the lazy dog.";
                        char[] message = originalMessage.ToCharArray();
                        Array.Reverse(message);
                        int letterCount = 0;
                        foreach (char letter in message) {
                            if (letter=='o') {
                                letterCount++;
                            }
                        }
                        string newMessage = new String(message);
                        Console.WriteLine(newMessage);
                        Console.WriteLine($"'o' appears {letterCount} times.");*/

        }
    }
}

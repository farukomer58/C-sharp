using System;
using System.Collections.Generic;

namespace FibonacciSequence {
    class Program {
        static void Main(string[] args) {

            var fibonacciSequence = new List<int> { 1, 1 };

            while (fibonacciSequence.Count<20) {
                // Get last 2 numbers
                int lastNum = fibonacciSequence[fibonacciSequence.Count-1];
                int secondNum = fibonacciSequence[fibonacciSequence.Count-2];

                fibonacciSequence.Add(lastNum+secondNum);
            }

            foreach (int num in fibonacciSequence) {
                    Console.WriteLine(num);
             }

        }
    }
}

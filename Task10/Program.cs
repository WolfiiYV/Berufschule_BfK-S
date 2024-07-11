using System;

namespace Task11 {
    internal class Program {
        static void Main(string[] args) {
            for (var i = 1; i <= 10; i++) {
                for (var j = 1; j <= 10; j++) {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }
            Console.ReadLine();
        }
    }
}

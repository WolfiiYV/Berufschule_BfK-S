using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntParserNew {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Geben Sie eine natürliche Zahl ein: ");
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input; i++) {
                if (i == input) {
                    Console.Write(i);
                } else {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine();
        }
    }
}
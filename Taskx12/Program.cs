using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskx12 {
    internal class Program {
        static void Main(string[] args) {
            int input;

            Console.Write("Bitte geben Sie die Start Zahl ein: ");
            input = int.Parse(Console.ReadLine());

            for (int i = input; i > 0; i--) {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Covid 3G Check");

            Console.Write("Sind sie geimpft: ");
            var vaccinatet = Console.ReadLine();

            Console.Write("Sind sie genesen: ");
            var recovery = Console.ReadLine();

            Console.Write("Sind sie getestet: ");
            var test = Console.ReadLine();

            CheckEntry(vaccinatet, recovery, test);
        }

        private static void CheckEntry(String vaccinatet, String recovery, String test) {
            switch (vaccinatet) {
                case "geimpft": 
                case "ja": 
                case "true":
                case "yes":
                case "j":
                case "y": {
                    Console.WriteLine("Sie dürfen das Gebäude betreten");
                    break;
                }
            }

            switch (recovery) {
                case "genesen":
                case "ja":
                case "true":
                case "yes":
                case "j":
                case "y": {
                    Console.WriteLine("Sie dürfen das Gebäude betreten");
                    break;
                }
            }

            switch (test) {
                case "getestet":
                case "ja":
                case "true":
                case "yes":
                case "j":
                case "y": {
                    Console.WriteLine("Sie dürfen das Gebäude betreten");
                    break;
                }
            }

            Console.Read();
        }
    }
}

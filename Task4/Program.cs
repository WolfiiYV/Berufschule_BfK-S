using System;

namespace Task4 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Geben sie eine Jahreszahl ein: ");
            var year = int.Parse(Console.ReadLine());

            /*
            //Debug for checking
            for (var a = 1; a < 2050; a++) {
                var t1 = false;
                var t2 = false;

                t1 = DateTime.IsLeapYear(year);

                if (year % 4 == 0) {
                    if (year % 100 == 0) {
                        if (year % 400 == 0) {
                            t2 = true;
                        }
                    }else {
                        t2 = true;
                    }
                }

                Console.WriteLine(t1 + " || " + t2 + " -> " + (t1 == t2) + " -> " + a);

                year++;
            }
            */

            var isLeapYear = false;

            if (year % 4 == 0) {
                if (year % 100 == 0) {
                    if (year % 400 == 0) {
                        isLeapYear = true;
                    }
                }else {
                    isLeapYear = true;
                }
            }

            Console.WriteLine("Das Jahr " + year + " ist " + (isLeapYear ? "ein " : "kein ") + "Schaltjahr");
            Console.WriteLine("\n\n\n\n");
            Console.Read();
        }
    }
}

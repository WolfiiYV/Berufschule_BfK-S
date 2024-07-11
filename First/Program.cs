using System;

namespace Task_1 {
    internal class Program {
        private static void Main() {
            //Main1();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            //altMain1();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            //Main2();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            Main3();
            Console.ReadLine();
        }

        private static void Main1() {
            var zahl1 = 1;
            var zahl2 = 6;
            var zahl3 = zahl1 + zahl2;

            Console.WriteLine(zahl3);

            Console.WriteLine("---");

            var zahl1x = 4;
            var zahl2x = 3.7;
            var zahl3x = zahl1x + zahl2x;

            Console.WriteLine(zahl3x);
        }

        private static void altMain1() {
            int zahl1 = 1;
            int zahl2 = 6;
            int zahl3 = zahl1 + zahl2;

            Console.WriteLine(zahl3);

            Console.WriteLine("---");

            int zahl1x = 4;
            double zahl2x = 3.7;
            double zahl3x = zahl1x + zahl2x;

            Console.WriteLine(zahl3x);
        }

        private static void Main2() {
            Console.WriteLine("Please input your last name.");

            var text = "Welcome Mr./Ms. ";

            Console.Write("LastName: ");

            var lastName = Console.ReadLine();

            if (lastName == string.Empty) {
                Console.WriteLine("There occurred an error while processing");

                Console.Write("You would like to try again? (y/n): ");

                var retry = Console.ReadLine();

                if (retry == "y" || retry == "yes" || retry == "ja" || retry == "j") {
                    Main2();
                    return;
                }
                else if (retry == string.Empty) {
                    Console.WriteLine("There occurred an error while processing");
                    Console.WriteLine("Stopping Program");
                    return;
                }

                return;
            }
            else {
                Console.Write("Would you like to change your name? (y/n): ");

                var change = Console.ReadLine();

                if (change == "y") {
                    Main2();
                }
                else {
                    return;
                }
            }

            Console.WriteLine(text + lastName);
        }


        private static void Main3() {


            int i;
            double d;

            i = 3 + 4 * 5;
            Console.WriteLine(i);

            i = (3 + 4) * 5;
            Console.WriteLine(i);

            i = 13 / 5;
            Console.WriteLine(i);

            d = 13.0 / 5.0;
            Console.WriteLine(d);

            i = 13 % 5;
            Console.WriteLine(i);

            Console.WriteLine("---");

            int i2 = 2;
            int erg2 = 0;

            erg2 = -i2;
            Console.WriteLine(erg2);
            erg2 = -(i2 - 4);
            Console.WriteLine(erg2);
            erg2 = -(-2);
            Console.WriteLine(erg2);

            Console.WriteLine("---");

            int i3 = 4, m3 = 5;

            int erg3 = 2 * ++i3;
            Console.WriteLine(erg3);

            erg3 = 2 * m3++;
            Console.WriteLine(erg3);

            erg3 = 2 * --i3;
            Console.WriteLine(erg3);

            erg3 = 2 * m3--;
            Console.WriteLine(erg3);

            Console.WriteLine("---");

            int a4 = 8, b4 = 3;

            a4++;
            --b4;
            int c4 = 2 * ++a4;
            int d4 = 2 * b4--;

            Console.WriteLine(a4);
            Console.WriteLine(b4);
            Console.WriteLine(c4);
            Console.WriteLine(d4);

            int c = 7;

            Console.WriteLine(c--);

            c = 7;
            Console.WriteLine(--c);
        }
    }
}
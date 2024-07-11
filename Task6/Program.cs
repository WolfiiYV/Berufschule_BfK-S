using System;

namespace Task6 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Wie viele Zonen befahren sie: ");
            var zonen = int.Parse(Console.ReadLine());

            Console.Write("Wie viele Fahrten führen sie aus: ");
            var fahrten = int.Parse(Console.ReadLine());

            var preisTag = 0.0;
            var preisWoche = 0.0;
            var zonenAlt = zonen;

            //Toggle for Task 1 (false = Task 1 | true = Task 2)
            var wochenkartenVerkauf = false;

            if (zonen>7) {
                zonen = 7;
            }

            switch (zonen) {
                case 1:
                    preisTag = 2.20;
                    preisWoche = 20.60;
                    break;
                case 2:
                    preisTag = 2.70;
                    preisWoche = 26.50;
                    break;
                case 3:
                    preisTag = 3.70;
                    preisWoche = 35.10;
                    break;
                case 4:
                    preisTag = 4.90;
                    preisWoche = 44.30;
                    break;
                case 5:
                    preisTag = 6.10;
                    preisWoche = 52.60;
                    break;
                case 6:
                    preisTag = 7.30;
                    preisWoche = 61.60;
                    break;
                case 7:
                    preisTag = 8.20;
                    preisWoche = 70.20;
                    break;
                default:
                    Console.WriteLine("Dies ist kein möglicher Wert!");
                    Console.Read();
                    return;
            }

            if ((preisTag * fahrten) >= preisWoche && wochenkartenVerkauf) {
                Console.WriteLine("Sie sollten ein Wochenticket kaufen");
                Console.WriteLine("Der Preis für " + zonenAlt + " Zonen beträgt " + preisWoche + "0 Euro");
            }
            else {
                Console.WriteLine("Sie sollten ein Tagesticket kaufen");
                Console.WriteLine("Bitte bezahlen sie " + fahrten + " fahrten für " + zonenAlt + " Zonen, " + preisTag * fahrten + " Euro " + "(" + preisTag + " Euro pro Ticket)");
            }

            Console.Read();
        }
    }
}

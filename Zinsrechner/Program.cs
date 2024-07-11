using System;

namespace Task9 {
    internal class Program {
        static void Main(string[] args) {

            double startKapital;
            double zinssatz;
            double zielSumme;


            try {
                Console.Write("Geben Sie Ihr Startkapital ein: ");

                var tempVar = Console.ReadLine();

                if (tempVar.Contains(".")) {
                    tempVar = tempVar.Replace(".", ",");
                }
                startKapital = double.Parse(tempVar);

                Console.Write("Geben Sie Ihren Zinssatz ein: ");

                tempVar = Console.ReadLine();
                if (tempVar.Contains(".")) {
                    tempVar = tempVar.Replace(".", ",");
                }
                zinssatz = double.Parse(tempVar);

                Console.Write("Geben Sie Ihre Zielsumme ein: ");

                tempVar = Console.ReadLine();
                if (tempVar.Contains(".")) {
                    tempVar = tempVar.Replace(".", ",");
                }

                zielSumme = double.Parse(tempVar);
            } catch (Exception) {
                return;
            }


            var jahre = 0;

            while (startKapital < zielSumme) {
                startKapital += startKapital * (zinssatz / 100);

                jahre++;
            }

            Console.WriteLine("Sie benötigen " + jahre + " Jahre um Ihr Ziel zu erreichen.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskx10 {
    internal class Program {
        static void Main(string[] args) {

            double startKapital;
            double zinssatz;
            int jahre;


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

                Console.Write("Geben Sie an wie lange Sie das Geld anlegen wollen: ");

                tempVar = Console.ReadLine();
                jahre = int.Parse(tempVar);
            } catch (Exception) {
                return;
            }

            for (int i = 1; i <= jahre; i++) {
                startKapital += startKapital * (zinssatz / 100);
            }

            Console.WriteLine("Ihr Kapital nach " + jahre + " Jahren beträgt: " + Math.Round(startKapital));
        }
    }
}

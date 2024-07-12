using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeAutomatNew {
    internal class Program {
        static void Main(string[] args) {

            var dKaffeePreis = 1.30;
            var dBezahlterBetrag = 0.00;

            Console.WriteLine("Willkommen! Ein Becher Kaffee kostst: " + dKaffeePreis.ToString("0.00") + " Euro");

            Console.WriteLine("Bezahlter Betrag: " + dBezahlterBetrag.ToString("0.00"));

            while (dKaffeePreis > dBezahlterBetrag) {
                Console.Write("Bitte werfen Sie eine Münze ein (InPut in Euro): ");

                double dMuenze;

                try {
                    var tempVar = Console.ReadLine();
                    if (tempVar.Contains(".")) {
                        tempVar = tempVar.Replace(".", ",");
                    }

                    dMuenze = double.Parse(tempVar);
                } catch (Exception) {
                    continue;
                }

                if (!(dMuenze <= 0)) {
                    dBezahlterBetrag += dMuenze;
                    Console.WriteLine("Bezahlter Betrag: " + dBezahlterBetrag.ToString("0.00"));
                    Console.WriteLine("Rest Betrag: " + (dKaffeePreis - dBezahlterBetrag).ToString("0.00"));
                }
            }

            Console.WriteLine("Entnehmen Sie Ihren Kaffee und Ihr Rückgeld: " + (dBezahlterBetrag - dKaffeePreis).ToString("0.00"));
        }
    }
}

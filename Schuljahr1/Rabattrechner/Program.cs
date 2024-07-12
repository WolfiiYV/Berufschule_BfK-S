using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabattrechnerNew {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Rabattrechner \n");

            Console.Write("Bitte geben Sie einen Betrag ein: ");
            var preis = double.Parse(Console.ReadLine());
            //Console.WriteLine("[DEBUG] " + preis);

            var rabatt = 0.0;

            //Extended Task
            if (preis >= 2000) {
                rabatt = preis * 0.05;
            } else if (preis > 1000) {
                rabatt = preis * 0.03;
            }

            /*
            //Default Task
            if (preis > 1000) {
                //3% Rabatt über 1000€
                rabatt = preis * 0.03;
            }
            */

            var rechnung = preis - rabatt;

            Console.WriteLine("Preis: " + preis);
            Console.WriteLine("Rabatt: " + rabatt);
            Console.WriteLine("Rechnungsbetrag: " + rechnung);

            Console.WriteLine("\n\n\n\n");
        }
    }
}
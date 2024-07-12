using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heizölrechner {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Heizölrechner \n");

            Console.Write("Name des zu beliefernden Kunden: ");
            var name = Console.ReadLine();
            //Console.WriteLine("[DEBUG] " + name);


            Console.Write("Bitte geben Sie den derzeitigen Netto-Heizölpreis in Litern an: ");
            var preis = double.Parse(Console.ReadLine());
            //Console.WriteLine("[DEBUG] " + preis);

            Console.Write("Bitte geben Sie den Tankstand des Tanklastzugs vor der Lieferung an: ");
            var tank_vor = double.Parse(Console.ReadLine());
            //Console.WriteLine("\n[DEBUG] " + tank_vor);

            Console.Write("Bitte geben Sie den Tankstand des Tanklastzugs nach der Lieferung an: ");
            var tank_nach = double.Parse(Console.ReadLine());
            //Console.WriteLine("\n[DEBUG] " + tank_nach);

            var tankDifferenz = tank_vor - tank_nach;
            var netto = tankDifferenz * preis;
            var mehrwert = netto * 0.19;
            var rechnung = netto + mehrwert;

            Console.WriteLine("\n--- Heizölrechnung für " + name + " ---");
            Console.WriteLine("Gelieferte Menge: " + tankDifferenz + " Liter");
            Console.WriteLine("Nettowert: " + netto + " Euro");
            Console.WriteLine("Mehwertsteuer: " + mehrwert + " Euro");
            Console.WriteLine("Rechnungsbetrag incl. Mwst: " + rechnung + " Euro");

            Console.WriteLine("\n\n\n\n");
        }
    }
}

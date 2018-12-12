using System;

namespace ConsoleAddierer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int zahl1;
            int zahl2;
            int summe;
            

            //Eingabe
            Console.WriteLine("Bitte geben sie eine Zahl ein:");
            
            zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben sie eine weiter Zahl ein:");

            zahl2 = Convert.ToInt32(Console.ReadLine());
            
            //Verarbeitung
            summe = zahl1 + zahl2;

            //Ausggabe
            Console.WriteLine("Die Summe von {0} und {1} beträgt: {2}",
                zahl1, zahl2, summe);
            Console.WriteLine("Berechnung abgeschlossen!");

        }
    }
}

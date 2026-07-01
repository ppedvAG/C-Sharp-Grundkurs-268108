using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace Lab_005_gemeinsam
{
    class Program
    {
        //Enum-Definition
        enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

        static void Main(string[] args)
        {
            //Schleife für Programm-Wiederholung
            do
            {
                //Eingabe und Parsing der ersten Zahl
                double zahl1 = ZahlEingabe("\nGib eine Zahl ein: ");

                //Eingabe und Parsing der zweiten Zahl
                double zahl2 = ZahlEingabe("\nGib eine weitere Zahl ein: ");

                Rechenoperation op = RechenoperationEingabe();

                //Deklaration und Initialisierung der Ergebnisvariablen
                double ergebnis = Berechne(zahl1, zahl2, op);

                //Frage nach der Wiederholung des Programms
                Console.WriteLine("Wiederholen? (Y/N) ");
                //Schleifenbedingungsprüfung anhand Tastendruck des Benutzers
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        static Rechenoperation RechenoperationEingabe()
        {
            bool funktioniert = true;
            int eingabe;
            do
            {
                // Ausgabe Generieren
                string infoAusgabe = "\nWähle eine Rechenoperation:\n";
                for (int i = 1; i < 5; i++)
                {
                    infoAusgabe += $"{i}: {(Rechenoperation)i}\n";
                }
                infoAusgabe += "Auswahl: ";

                eingabe = (int)ZahlEingabe(infoAusgabe);
                if (eingabe < 1 || eingabe > 4)
                {
                    funktioniert = false;
                } else
                {
                    funktioniert = true;
                }
            } while (!funktioniert);

            return (Rechenoperation) eingabe;
        }

        static double ZahlEingabe(string text)
        {
            bool funktioniert;
            double ergebnis;
            do
            {
                Console.WriteLine(text);
                string eingabe = Console.ReadLine();
                funktioniert = double.TryParse(eingabe, out ergebnis);
            } while (!funktioniert);
            return ergebnis;
        }

        // return double braucht man nicht unbedingt
        static double Berechne(double zahl1, double zahl2, Rechenoperation operation)
        {
            double ergebnis;
            //Switch zur Auswahl der Rechenoperation
            switch (operation)
            {
                //Berechnung des Ergebnisses
                case Rechenoperation.Addition:
                    ergebnis = zahl1 + zahl2;
                    Console.WriteLine($"{zahl1} + {zahl2} = {ergebnis}");
                    break;
                case Rechenoperation.Subtraktion:
                    ergebnis = zahl1 - zahl2;
                    Console.WriteLine($"{zahl1} - {zahl2} = {ergebnis}");
                    break;
                case Rechenoperation.Multiplikation:
                    ergebnis = zahl1 * zahl2;
                    Console.WriteLine($"{zahl1} * {zahl2} = {ergebnis}");
                    break;
                case Rechenoperation.Division:
                    //Prüfung einer möglichen Teilung durch null
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("\nEine Division durch 0 ist nicht erlaubt.");
                        ergebnis = double.NaN;
                        break;
                    }
                    ergebnis = zahl1 / zahl2;
                    Console.WriteLine($"{zahl1} / {zahl2} = {ergebnis}");
                    break;
                default:
                    //Fall, welcher eintrofft, wenn keine valide Rechenoperation ausgewählt wurde
                    Console.WriteLine("\nFehlerhafte Eingabe bei Auswahl der Rechenoperation");
                    ergebnis = double.NaN;
                    break;
            }
            return ergebnis;
        }
    }
}

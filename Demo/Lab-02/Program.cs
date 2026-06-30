using System;

namespace Lab_002
{
    class Program
    {
        static void Main(string[] sender)
        {
            // 1. Variablen für die Eingabe deklarieren
            double entfernungMeter;
            double stunden;
            double minuten;
            double sekunden;

            // 2. Benutzereingaben abfragen und konvertieren (Parse)
            Console.Write("Bitte Entfernung in Metern eingeben: ");
            entfernungMeter = double.Parse(Console.ReadLine());

            Console.Write("Bitte Stunden eingeben: ");
            stunden = double.Parse(Console.ReadLine());

            Console.Write("Bitte Minuten eingeben: ");
            minuten = double.Parse(Console.ReadLine());

            Console.Write("Bitte Sekunden eingeben: ");
            sekunden = double.Parse(Console.ReadLine());

            // 3. Gesamtzeit in Sekunden berechnen
            // (Hinweis: Wir nutzen direkt double, um Ganzzahl-Divisionsfehler in Schritt 4 zu vermeiden)
            double gesamtZeitSekunden = (stunden * 3600) + (minuten * 60) + sekunden;

            // 4. Geschwindigkeiten berechnen
            // Meter pro Sekunde (m/s)
            double meterProSekunde = entfernungMeter / gesamtZeitSekunden;

            // Kilometer pro Stunde (km/h)
            double kmProStunde = meterProSekunde * 3.6;

            // Meilen pro Stunde (mph)
            double meilenProStunde = kmProStunde * 0.62137119;

            // 5. Ergebnisse auf zwei Nachkommastellen runden und ausgeben
            Console.WriteLine("\n--- Ergebnisse ---");
            Console.WriteLine("Geschwindigkeit in m/s: " + Math.Round(meterProSekunde, 2));
            Console.WriteLine("Geschwindigkeit in km/h: " + Math.Round(kmProStunde, 2));
            Console.WriteLine("Geschwindigkeit in Meilen/h: " + Math.Round(meilenProStunde, 2));

            // Konsole offen halten
            Console.ReadLine();
        }
    }
}
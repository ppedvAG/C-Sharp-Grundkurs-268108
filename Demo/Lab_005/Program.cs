namespace Lab_005
{
    internal class Program
    {
        // Enum für mathematische Operationen
        enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

        static void Main(string[] args)
        {
            // Endlosschleife für wiederholte Berechnungen
            while (true)
            {
                // Eingabe der beiden Zahlen
                double zahl1 = GetInput("Gib eine Zahl ein: ");
                double zahl2 = GetInput("Gib eine weitere Zahl ein: ");

                // Verfügbare Operationen anzeigen
                foreach (Rechenoperation op in Enum.GetValues<Rechenoperation>())
                {
                    Console.WriteLine($"{(int)op}: {op}");
                }

                // Rechenoperation auswählen und berechnen
                Rechenoperation operation = GetRechenoperation();
                double ergebnis = Berechne(zahl1, zahl2, operation);
                string symbol = ConvertRechenoperation(operation);
                Console.WriteLine($"{zahl1} {symbol} {zahl2} = {ergebnis}");

                // Abfrage zum Wiederholen
                Console.WriteLine("Wiederholen? (Enter)");
                if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                    break;
            }
        }

        // Validierte Zahleneingabe mit Schleife
        static double GetInput(string text)
        {
            while (true)
            {
                Console.Write(text);
                string eingabe = Console.ReadLine();
                double zahl;
                // TryParse: sichere Konvertierung - liefert true/false statt Exception zu werfen
                bool funktioniert = double.TryParse(eingabe, out zahl);
                if (funktioniert)
                    return zahl;
                // Bei fehlerhafte Eingabe: Schleife beginnt neu (Wiederholung der Eingabeaufforderung)
            }
        }

        // Liest und validiert die Rechenoperation
        static Rechenoperation GetRechenoperation()
        {
            // Alle möglichen Enum-Werte in ein Array speichern zur späteren Prüfung
            Rechenoperation[] alleOperationen = Enum.GetValues<Rechenoperation>();
            while (true)
            {
                string eingabe = Console.ReadLine();
                Rechenoperation operation;
                // TryParse: versucht String in Enum zu konvertieren, speichert Ergebnis in 'operation' ab
                bool funktioniert = Enum.TryParse<Rechenoperation>(eingabe, out operation);
                // Prüft, ob die eingegebene Operation in der Liste der erlaubten Operationen existiert
                if (!alleOperationen.Contains(operation))
                {
                    Console.WriteLine("Keine gültige Rechenoperation ausgewählt");
                    continue;
                }
                if (funktioniert)
                    return operation;
            }
        }

        // Führt die gewählte Berechnung durch
        static double Berechne(double x, double y, Rechenoperation op)
        {
            switch (op)
            {
                case Rechenoperation.Addition:
                    return x + y;
                case Rechenoperation.Subtraktion:
                    return x - y;
                case Rechenoperation.Multiplikation:
                    return x * y;
                case Rechenoperation.Division:
                    // Ternärer Operator: Bedingung ? wenn wahr : wenn falsch
                    // Verhindert Division durch Null indem NaN zurückgegeben wird
                    return y != 0 ? x / y : double.NaN;
                default:
                    return double.NaN;
            }
        }

        // Konvertiert Rechenoperation in mathematisches Symbol
        static string ConvertRechenoperation(Rechenoperation op)
        {
            switch (op)
            {
                case Rechenoperation.Addition:
                    return "+";
                case Rechenoperation.Subtraktion:
                    return "-";
                case Rechenoperation.Multiplikation:
                    return "*";
                case Rechenoperation.Division:
                    return "/";
                default:
                    return "";
            }
        }
    }
}
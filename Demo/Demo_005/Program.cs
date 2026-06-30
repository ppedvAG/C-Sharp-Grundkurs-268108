namespace Demo_005
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Aufruf der "SummeAusgeben(zahl1, zahl2)" Funktion
            SummeAusgeben(1, 2);
            SummeAusgeben(5, 9);
            SummeAusgeben(2, 7);

            // Aufruf der Funktion Addiere(...)
            Console.WriteLine(Addiere(12, 3));
            int summe = Addiere(4, 5);
            Console.WriteLine(summe);

            // Aufruf der Überladenen Funktion
            Console.WriteLine(Addiere(1.2, 6));


            // Aufruf der Überladenen Funktion mit Array 
            Console.WriteLine(Addiere([1, 2, 3, 4, 5, 6, 7, 7, 87, 6,]));

            // Aufruf der Überladenen Funktion mit Array und Params
            Console.WriteLine(Addiere(21, 6, 54, 31));


            // Aufruf der Funktion Berechne mit mehreren OUT Parametern
            int min, max, differenz, produkt;
            double avg, quotient;
            summe = Berechne(12, 7, out differenz, out produkt, out quotient, out avg, out max, out min);

            Console.WriteLine($"Summe: {summe}\n" +
                $"Differenz: {differenz}\n" +
                $"Produkt: {produkt}\n" +
                $"Quotient: {quotient}\n" +
                $"Avg: {avg}\n" +
                $"Min: {min}\n" +
                $"Max: {max}\n");
        }
        static void SummeAusgeben(int zahl1, int zahl2)
        {
            int summe = zahl1 + zahl2;
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}");
        }

        // Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        // Der Kopf besteht aus den MODIFIERN (public, statc, etc.), dem RÜCKGABETYP (int, void, double,...), dem NAMEN (Addiere)
        // sowie den ÜBERGABEPARAMETERN (int zahl1, int zahl2)
        static int Addiere(int zahl1, int zahl2)
        {
            // der RETRUN- Befeahl weist die Methode an,  einen Wert als Rückgabewert an den Aufrufer zurückzugeben
            return zahl1 + zahl2; // Retrun beendet außerdem die Funktion!
        }

        // Funktionen dürfen nicht gleich heißen
        // AUSNAHME: wenn die Parameter unterschiedlich sind
        // Funktion, welche den gleichen Bezeichner hat (nennt man ÜBERLADENE Funktionen). Diese müssen sich in der Anzahl und/oder 
        // der Art der Parameter unterscheiden, damit der Aufruf eindeutig ist.
        static double Addiere(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }

        // Das PARAMS-Stichwort erlaubt die Übergabe einer beliebegen Anzahl von gleichartigen Daten, 
        // welche innerhalb der Methode als Array interpretiert werden
        static int Addiere(params int[] zahlen)
        {
            return zahlen.Sum();
        }

        // Das OUT-Stichwort ermöglicht einer Methode mehr als einen Rückgabewert zu haben. Dabei kann die Variable direkt in der
        // Funktionsübergabe deklariert werden
        static int Berechne(int zahl1, int zahl2,
            out int differenz,
            out int produkt,
            out double quotient,
            out double avg,
            out int max,
            out int min)
        {
            differenz = zahl1 - zahl2;
            produkt = zahl1 * zahl2;
            avg = (zahl1 + zahl2) / 2.0;
            if (zahl1 < zahl1)
            {
                min = zahl1;
                max = zahl2;
            }
            else if (zahl1 > zahl2)
            {
                min = zahl2;
                max = zahl1;
            }
            else
            {
                min = max = zahl1;
            }
            if (zahl2 == 0)
            {
                quotient = double.NaN;
            }
            else
            {
                quotient = (double)zahl1 / zahl2;

            }
            return zahl1 + zahl2;
        }


    }
}
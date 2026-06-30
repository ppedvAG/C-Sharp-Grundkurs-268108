using System;

namespace Lab003
{
    class Program
    {
        static void Main(string[] sender)
        {
            #region Schaltjahr-Rechner
            // 1. Eingabe des Jahres (Du kannst hier zum Testen 2020, 2000 oder 1800 eintragen)
            Console.Write("Bitte gib ein Jahr ein: ");
            int jahr;
            if (int.TryParse(Console.ReadLine(), out jahr))
            {



                // 2. Variable vom Typ bool anlegen (standardmäßig erst mal false)
                bool istSchaltjahr = false;

                // verkürzte Lösung
                if (jahr % 4 == 0)
                    istSchaltjahr = true;

                if (jahr % 100 == 0)
                    istSchaltjahr = false;

                if (jahr % 400 == 0)
                    istSchaltjahr = true;

                // Ganz kurze Lösung
                //istSchaltjahr = DateTime.IsLeapYear(jahr);

                // 3. Die Bedingungen Schritt für Schritt prüfen
                if (jahr % 4 == 0)
                {
                    if (jahr % 100 == 0)
                    {
                        if (jahr % 400 == 0)
                        {
                            istSchaltjahr = true; // Durch 4, 100 und 400 teilbar -> Schaltjahr (z.B. 2000)
                        }
                        else
                        {
                            istSchaltjahr = false; // Durch 4 und 100, aber NICHT durch 400 teilbar -> Kein Schaltjahr (z.B. 1800)
                        }
                    }
                    else
                    {
                        istSchaltjahr = true; // Durch 4 teilbar, aber nicht durch 100 -> Schaltjahr (z.B. 2020)
                    }
                }
                else
                {
                    istSchaltjahr = false; // Nicht mal durch 4 teilbar -> Kein Schaltjahr
                }

                // 4. Ausgabe des Ergebnisses
                if (istSchaltjahr)
                {
                    Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine($"Das Jahr {jahr} ist KEIN Schaltjahr.");
                }
            }
            else
            {
                Console.WriteLine("Eingabe Fehlerhaft");
            }
            #endregion


            #region Mini-Lotto
            // 1. Gewinnzahlen im Array definieren (5 Zahlen zwischen 0 und 100)
            Random random = new Random();

            int[] gewinnZahlen = new int[5];

            for (int i = 0; i < 5; i++)
            {
                gewinnZahlen[i] = random.Next(1,101);
                Console.WriteLine(gewinnZahlen[i]);
            }

            //int i = 0;
            //foreach(int zahl in gewinnZahlen)
            //{
            //    gewinnZahlen[i] = random.Next(1, 101);
            //    i++;
            //}
            
            //int i = 0;
            //while (i < 5)
            //{
            //    gewinnZahlen[i] = random.Next(1, 101);
            //    Console.WriteLine(gewinnZahlen[i]);
            //    i++;
            //}

            // 2. Benutzereingabe abfragen
            Console.Write("Gib eine Zahl zwischen 1 und 100 ein: ");
            int tipp;
            if (!int.TryParse(Console.ReadLine(), out tipp))
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }
            else
            {


                // 3. Prüfen, ob der Tipp im erlaubten Bereich liegt
                if (tipp < 0 || tipp > 100)
                {
                    Console.WriteLine("Fehler: Deine Zahl liegt nicht im Bereich zwischen 0 und 100!");
                }
                else
                {
                    // 4. Wenn der Bereich stimmt, prüfen wir mit .Contains() auf einen Gewinn
                    if (gewinnZahlen.Contains(tipp))
                    {
                        Console.WriteLine($"Herzlichen Glückwunsch! Die {tipp} ist eine Gewinnzahl!");
                    }
                    else
                    {
                        Console.WriteLine($"Schade, die {tipp} war leider kein Treffer. Viel Glück beim nächsten Mal!");

                        // Zusatz: erfahren, ob  die nächste Gewinnzahl größer oder kleiner als der Tipp ist
                        int minAbstand = 101;
                        int naehesteZahl = gewinnZahlen[0];
                        foreach (var item in gewinnZahlen)
                        {
                            if (Math.Abs(item - tipp) < minAbstand)
                            {
                                minAbstand = Math.Abs(item - tipp);
                                naehesteZahl = item;
                            }
                            else if (Math.Abs(item - tipp) == minAbstand)
                            {
                                Console.WriteLine("2 Zahlen sind gleich nahe!");
                            }

                        }
                        if (naehesteZahl > tipp)
                            Console.WriteLine("Nächste Gewinnzahl ist größer");
                        else
                            Console.WriteLine("Nächste Gewinnzahl ist kleiner");


                    }
                }
            }
            #endregion
        }
    }
}




        
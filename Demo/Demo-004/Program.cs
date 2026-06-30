namespace Demo004
{
    // Wenn Conde von anderen Namespaces verwendet werden soll, dann using namespace; schreiben
    using asdf;
    class Program
    {
        public static void Main(string[] args)
        {
            #region Schleifen
            //int a = 0;
            //int b = 10;

            //// While Schleife
            //// Die While-Schleife wird wiederholt, solange die Bedingung wahr ist.
            //// Ist die Bedingung von vornherein unwahr, dann wird die Schleife übersprungen
            //while (a < b)
            //{
            //    Console.WriteLine("A ist kleiner als B");
            //    a++;
            //    // Mit der Break-Anweisung wird die Schleife verlassen
            //    if (a == 5)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"Schleifenende. A ist {a} und B ist {b}");


            //a = -45;
            //// Do-While-Schleife
            //// Auch die Do-While Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst
            //// am Schleifenende geprüft, weshalb die Schleife mindestens ein mal durchläuft
            //do
            //{
            //    // continue - Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen
            //    // Ist die Bedingung wahr, beginnt ein neuer duchlauf
            //    if (a < -10 && a > -20)
            //    {
            //        a++;
            //        continue;
            //    }
            //    Console.WriteLine(a);
            //    a++;

            //} while (a < 0);



            //// Typischer Anwendungsfall für Do-While Schleife mit continue
            //// - Userabfrage: Möchtest du wiederholen?
            //#region Mini-Lotto
            ////Random random = new Random();
            ////int[] gewinnZahlen = new int[5];
            ////for (int i = 0; i < 5; i++)
            ////{
            ////    gewinnZahlen[i] = random.Next(1, 101);
            ////}

            ////ConsoleKeyInfo k = new ConsoleKeyInfo();
            ////do
            ////{
            ////    // 2. Benutzereingabe abfragen
            ////    Console.Write("Gib eine Zahl zwischen 1 und 100 ein: ");
            ////    int tipp;
            ////    if (!int.TryParse(Console.ReadLine(), out tipp))
            ////    {
            ////        Console.WriteLine("Fehlerhafte Eingabe!\n");
            ////        continue; // User hat keine Zahl eingegeben. Eingabe beginnt von vorne.
            ////    }

            ////    // 3. Prüfen, ob der Tipp im erlaubten Bereich liegt
            ////    if (tipp < 0 || tipp > 100)
            ////    {
            ////        Console.WriteLine("Fehler: Deine Zahl liegt nicht im Bereich zwischen 0 und 100!\n");
            ////        continue; // User hat zu große/kleine Zahl eingegeben. Eingabe beginnt von vorne.
            ////    }

            ////    // 4. Wenn der Bereich stimmt, prüfen wir mit .Contains() auf einen Gewinn
            ////    if (gewinnZahlen.Contains(tipp))
            ////    {
            ////        Console.WriteLine($"Herzlichen Glückwunsch! Die {tipp} ist eine Gewinnzahl!\n");
            ////        break;
            ////    }

            ////    Console.WriteLine($"Schade, die {tipp} war leider kein Treffer. Viel Glück beim nächsten Mal!");

            ////    // Zusatz: erfahren, ob  die nächste Gewinnzahl größer oder kleiner als der Tipp ist
            ////    int minAbstand = 101;
            ////    int naehesteZahl = gewinnZahlen[0];
            ////    foreach (var item in gewinnZahlen)
            ////    {
            ////        if (Math.Abs(item - tipp) < minAbstand)
            ////        {
            ////            minAbstand = Math.Abs(item - tipp);
            ////            naehesteZahl = item;
            ////        }
            ////        else if (Math.Abs(item - tipp) == minAbstand)
            ////        {
            ////            Console.WriteLine("2 Zahlen sind gleich nahe!");
            ////        }

            ////    }
            ////    if (naehesteZahl > tipp)
            ////        Console.WriteLine("Nächste Gewinnzahl ist größer");
            ////    else
            ////        Console.WriteLine("Nächste Gewinnzahl ist kleiner");


            ////    Console.WriteLine("Möchtest du nochmal versuchen? (J/N)");
            ////    k = Console.ReadKey();
            ////    Console.WriteLine("\n");

            ////} while (k.Key != ConsoleKey.N);

            ////Console.Write("Die gewinnzahlen wären gewesen: ");
            ////// Schleife zum iterieren über Arrays (oder andere Aufzählungstypen Listen, Dictionarys, Strings, ...)
            ////foreach(int gewinnZahl in gewinnZahlen) { 

            ////    Console.Write(gewinnZahl + "\t");
            ////}
            //#endregion

            //// FOR-Schleife
            //// Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung gegeben. 
            //// Am Ende jedes Durchlaufs wird die Anweisung ausgeführt. Wenn die Bedingung false ist (wird), wird die Schleife verlassen
            //Console.WriteLine("\n");
            //for (int i = 0; i<10; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\n");
            //int[] zahlen = { -654,87, 654, 1, 2, 3, 4};
            //// Iteration über ein Array mittels for Schleife
            //for(int i =0; i<zahlen.Length; i++)
            //{
            //    Console.WriteLine(zahlen[i]);
            //}

            //Console.WriteLine("\n");
            //// FOREACH Schleifen können über Collections (zB Array) laufen und sprechen dabei jedes Element genau einmal an
            //foreach(int zahl in zahlen)
            //{
            //    Console.WriteLine(zahl);
            //}
            //Console.WriteLine("\n");


            //// Strings
            ////char[] c = { 'H', 'a', 'l', 'l', 'o' }; //String könnte man sich so vorstellen
            //string hallo = "Hallo";
            //foreach(char zeichen in hallo)
            //{
            //    Console.WriteLine(zeichen);
            //}
            //Console.WriteLine("\n");
            //for(int i = 0; i<hallo.Length; i++)
            //{
            //    Console.WriteLine(hallo[i]);
            //}

            #endregion

            #region Enums
            Wochentag heutigerTag = Wochentag.Dienstag;
            Console.WriteLine($"Heute ist also {heutigerTag}.");

            Console.WriteLine("Welcher ist dein Lieblingstag?");
            for(int i = 1; i<8; i++)
            {
                // Int in Enum Casten ergibt den jeweileiligen Tag als Text
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            // Speichern einer Benutzereingabe (Int) als Enum
            // Cast: INT->Wochentag
            Wochentag lieblingsTag = (Wochentag) int.Parse(Console.ReadLine());
            Console.WriteLine($"Also dein Lieblingstag ist der {lieblingsTag}.");
            if (lieblingsTag == heutigerTag) Console.WriteLine("Sei glücklich!");
            // Casts generell:
            int zahl1 = 8;
            int zahl2 = 7;
            double zahl3 = (double)zahl1/zahl2;
            Console.WriteLine(zahl3);
            Console.WriteLine((Wochentag)zahl2);

            #region switch
            // SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zuständer der übergebenen Variable
            // werden inden CASES bearbeitet
            switch(lieblingsTag)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Liebligstag ist Wochenstart");
                    break;
                case Wochentag.Dienstag:
                    Console.WriteLine("Sei glücklich");
                    break;
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Lieblingstag ist normaler Wochentag");
                    break;
                default:
                    Console.WriteLine("Lieblingstag ist Wochenende");
                    break;

            }


            #endregion
        }
    }
    // Enums müssen außerhalb einer Klasse definiert werden.
    //public enum Wochentag { Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }
    // Oder in anderer Datei auch außerhalb einer Klasse: Class1.cs
    #endregion
}

namespace Demo
{
    class Program
    {
        // Main-Funktion ist der Start in das Programm.
        // Der Code in Main wird ausgeführt wenn ich das Demo Projekt starte.
        public static void Main()
        {


            // - Modul 1 --------------------------------------------------------------------------------
            ////Einzeilige Kommetare
            //int number = 0; // Einzeilige Kommentare können auch nach code stehen.

            ///// Mit 3 /s kann ich 
            ///// einfach
            ///// weiterschreiben 
            ///// in 
            ///// der nächsten
            ///// Zeile

            ///*Mehrzeilige
            // * 



            // Kommentare mit : */


            //// strg + #: Zeile Auskommentiern/Kommentar entfernen


            //// Befehle: sind zb. Funktionen von C#
            //Console.WriteLine("Hallo!"); // Schreibt eine Zeile auf die Konsole

            //// Zweisungen: Variablen einen Wert geben
            //string text = "Das ist ein Text";
            //Console.WriteLine(text);


            // - Modul 2 --------------------------------------------------------------------------------
            // Variablen und Strings
            
            // Variablen Deklaration
            string ausgabe = "Bitte deinen Namen eingeben:"; // mit Wertzuweisung
            string name; // ohne Wertzuweisung

            // Variablenverwendung
            Console.WriteLine(ausgabe); // ausgeben
            name = Console.ReadLine(); // Wertzuweisung (mit Readline -> Text von Konsole)

            // ausgabe mit $-String
            Console.WriteLine($"Willkommen {name}, schön, dass du da bist!");
            Console.WriteLine("Willkommen " + name + ", schön, dass du da bist!");

            // Taschenrechner zum Addieren
            Console.WriteLine("Zahl 1 eingeben:");
            string number1 = Console.ReadLine();
            Console.WriteLine("Zahl 2 eingeben: ");
            string number2 = Console.ReadLine();
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            // Ausgabe: 12+6=126
            // Weil number1 und number2 string sind, die werden beim addiern aneinander gehängt

            // Taschenrechner zum Addieren - KORRIGIERT
            Console.WriteLine("Zahl 1 eingeben:");
            int n1 = int.Parse(Console.ReadLine()); // int.Parse ist eine Funktion
            Console.WriteLine("Zahl 2 eingeben: "); // sie wandlet string in int um
            int n2 = int.Parse(Console.ReadLine()); // bei Fehler stürtzt das Programm ab

            Console.WriteLine(n1+" + "+n2+" = "+(n1 + n2));
            Console.WriteLine($"{n1} + \n{n2} = {n1 + n2}");
            Console.WriteLine(@"{0} + 
{1} = {2}", n1, n2, n1 + n2);



        }

    }
}
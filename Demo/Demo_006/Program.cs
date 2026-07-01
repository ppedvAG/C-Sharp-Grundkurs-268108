// Wenn man Code aus anderen Namespaces verwenden möchte, dann using-Anweisungen verwenden
using Demo_005;

namespace Demo_006
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Funktion aus Demo_005.Program aufrufen (statische Methode ruft man über den Klassennamen auf)
            Demo_005.Program.SummeAusgeben(1, 2);

            // Deklaration von Lebewesen-Variablen und Instanzierung von neuen Lebewesen-Objekten
            Lebewesen pferd = new Lebewesen(); // Konstruktoraufruf
            Lebewesen hase = new Lebewesen();

            // Lesezugriff auf die Eigenschaft Name (Getter)
            Console.WriteLine(pferd.Name);
            Console.WriteLine(hase.Name);

            // Schreibzugriff auf die Eigenschaft Name (Setter)
            pferd.Name = "Silbermond";
            hase.Name = ""; // Name wird Hugo bleiben, weil Länge kleiner 1

            // Lesezugriff auf die Eigenschaft Name (Getter)
            Console.WriteLine(pferd.Name);
            Console.WriteLine(hase.Name);

            Console.WriteLine(pferd.Alter); // 0, weil Alter nicht gesetzt wurde
            pferd.Alter = 3;
            hase.Alter = 1;
            Console.WriteLine(pferd.Alter);
            Console.WriteLine(hase.Alter);

            // Neues Objekt mit neuem Konstruktor erzeugen
            Lebewesen kakerlake = new Lebewesen("Kurt");
            kakerlake.Alter = 1;
            Console.WriteLine($"Kakerlake {kakerlake.Name} ist {kakerlake.Alter} Jahr alt");

            Lebewesen giraffe = new Lebewesen("Gisela", 6);

            // Methode verwenden
            Lebewesen giraffenKind = giraffe.GebaereKind("Jonny");
            Console.WriteLine(giraffenKind.Name);
            Console.WriteLine(giraffenKind.Mutter.Name);

            Lebewesen hasenKind = new Lebewesen("Lisa", 0, hase);
            Console.WriteLine(hasenKind.Name);
            Console.WriteLine(hasenKind.Mutter.Name);

            Lebewesen katzenKind = new Lebewesen("Lila", 0, new Lebewesen("Murli", 3));
            katzenKind.InfoAusgeben();
            
        }
    }
}
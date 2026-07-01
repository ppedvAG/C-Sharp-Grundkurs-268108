namespace Lab_007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Lab 07: GC und statische Member

            //Generierung von div. Objekten (zur Überschwemmung des RAM)
            Fahrzeug fz1 = new Fahrzeug("BMW", 230, 25999.99);
            for (int i = 0; i < 1000; i++)
            {
                fz1 = new Fahrzeug("BMW", 230, 25999.99);
            }

            //Aufruf der statischen Methode
            Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

        }
    }
}
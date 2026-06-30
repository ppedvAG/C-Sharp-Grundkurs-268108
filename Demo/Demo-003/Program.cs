
namespace Demo003
{
    using System.Globalization;
    public class Program
    {

   
        public static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            #region Arrays
            // Array: Variable, welche mehrere Werte halten kann
            // Wird definiert mit Datentyp + []


            int[] numbers = new int[5]; // Array mit Größe 5 erstellen (new int[])
            numbers[0] = 1; // Schreibe an Position 0 die Zahl 1
            numbers[1] = 2; // Schreibe an Position 1 die Zahl 2
            numbers[2] = 3;
            numbers[3] = 4;
            Console.WriteLine(numbers[4]); // Ausgabe 0 
                                           // C# Arrays werden mit Standardwerten befüllt, wenn sie leer sind
                                           // Standardwert von int ist 0
            numbers[4] = 5;
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            // Foreachschleife wird später erklärt, hier wird jedes Element von numbers ausgegeben

            // Direkte Initialisierung
            //double[] numbers2 = new double[]{ 1.1, 1.2, 1.3 };
            //double[] numbers2 = new[] { 1.1, 1.2, 1.3 };
            double[] numbers2 = { 1.1, 1.2, 1.3 };
            double[] numbers3 = [1.1, 2.3, 4.3];

            // Length ist Eigenschaft (Variable) von Array und gibt die Länge an (int)
            Console.WriteLine(numbers2.Length);

            // Contains kann man prüfen, ob ein Element vorhanden ist
            Console.WriteLine(numbers3.Contains(2.3));

            if(numbers3.Contains(2.3))
            {
                Console.WriteLine(1);
            } else
            {
                Console.WriteLine(0);
            }

            // Maximum von numbers3:
            Console.WriteLine(numbers3.Max());
            string[] words = { "blau", "gelb", "rot" };
            Console.WriteLine(words.Max()); // bei Strings alphabetisch
            // Minimum von numbers3:
            Console.WriteLine(numbers3.Min());
            // Average von numbers3:
            Console.WriteLine(numbers3.Average());
            // Summe von numbers
            Console.WriteLine(numbers.Sum());
            //bool[] values = { true, true };
            //Console.WriteLine(values.Sum()); // Sum/Avg ist nur bei Zahlen erlaubt

            // First und Last
            Console.WriteLine(numbers3.First());
            Console.WriteLine(numbers3[0]);
            Console.WriteLine(numbers3.Last());
            Console.WriteLine(numbers3[numbers3.Length-1]);

            // Zwei Dimensionen
            int[,] numberTable = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };
            Console.WriteLine(numberTable[1, 1]);
            Console.WriteLine(numberTable[0, 3]);
            //Console.WriteLine(numberTable[1, 4]);
            Console.WriteLine(numberTable[0, numberTable.GetLength(1)-1]);
            #endregion

            
            // =>
            // >=
        }
    }
}
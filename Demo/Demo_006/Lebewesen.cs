using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_006
{
    // KLASSEN sind Vorlagen für Objekte. Sie bestimmen Eigenschaften und Funktionen dieser Objekte.
    public class Lebewesen
    {


        #region Felder und Eigenschaften
        // FELDER (Membervariablen) sind die Variablen einzenlner Objekte, welche Zustände dieser Objekte speichen.
        private string name = "Hugo";

        // EIGENSCHAFTEN (Properties) definern mittels Getter/Setter den Lese-/Schreibzugriff auf jeweils ein Feld.
        // In den Eigenschaften können bestimmte Bedingungen für das Lesen/Schreiben der Felder gesetzt werden,
        // sowie der Zugriff für Lesen und Schreiben einzelnd angepasst werden.
        public string Name
        {
            get { return name; } // Getter: Gibt den Wert des Feldes zurück (lesen)
            set
            {
                if (value.Length > 0)
                    name = value;
            } // Setter: Setzt den Wert des Feldes (schreiben)
        }


        // Eigenschaften erzeugen automatisch ein Feld (Auto-Property)
        // Allerdings kann man hier keine Bedingungen für das Lesen/Schreiben setzen
        public int Alter { get; set; }// Auto-Property: Erzeugt automatisch ein Feld, auf das über die Eigenschaft zugegriffen werden kann
        
        public Lebewesen Mutter { get; private set; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor: Wird automatisch erzeugt, wenn kein Konstruktor explizit definiert wurde.
        public Lebewesen() { }

        // Konstruktor mit Name:
        // Wenn kein Standardkonstruktor explizit definiert wurde (Konstruktor ohne Parameter Zeile 36)
        // Dann muss beim Erzeugen dieser Konstruktor mit Name verwendet werden.
        public Lebewesen(string name)
        {
            this.Name = name;
        }

        // Konstruktor mit Name und Alter
        // mit this(name) wird Konstroktor von oben aufgerufen und ich spare Code
        public Lebewesen(string name, int alter): this(name)
        {
            this.Alter = alter;
        }

        public Lebewesen(string name, int alter, Lebewesen mutter): this(name, alter)
        {
            this.Mutter = mutter;
        }
        #endregion

        #region Methoden

        // MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt
        // und speziell mit diesem Objekt interagiert
        public Lebewesen GebaereKind(string name)
        {
            return new Lebewesen(name, 0, this);
        }

        // Info Ausgeben Methode
        public void InfoAusgeben()
        {
            if (this.Mutter != null)
            {
                Console.WriteLine("Lebwesen:\n" +
                    $"\tName: {this.Name}\n" +
                    $"\tAlter: {Alter}\n" +
                    $"\tMutter: {Mutter.Name}");
            } else
            {
                Console.WriteLine("Lebwesen:\n" +
                    $"\tName: {this.Name}\n" +
                    $"\tAlter: {Alter}\n" +
                    $"\tMutter ist unbekannt.");
            }
        }
        #endregion
    }
}

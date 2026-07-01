
using Demo_M007;

Console.OutputEncoding = System.Text.Encoding.UTF8;

for (int i =0; i<100; i++)
{
    Fahrzeug fahrzeug = new Fahrzeug("Auto"+i, 180, 100_000);
}
// statische Member über den Klassennamen ansprechen (Console.Writeline(), Fahrzeug.PreisGes, Fahrzeug.AusgabePreisGes)
Fahrzeug.AusgabePreisGes();
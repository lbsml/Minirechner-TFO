using System;

namespace Minirechner
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;
            int Erg = 0;



            Console.WriteLine("Minirechner-TFO");
            Console.WriteLine();
            Console.WriteLine("Bitte geben Sie die erste Zahl ein: ");
            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein: ");
            Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Wählen Sie die gewünschte Grundrechnungsart aus!);
            Console.WriteLine("1    Addieren");
            Console.WriteLine("2    Subtrahieren");
            Console.WriteLine("3    Multiplizieren");
            Console.WriteLine("4    Dividieren");
            Console.ReadKey();
        }
    }
}

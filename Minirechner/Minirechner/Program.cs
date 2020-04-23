using System;

namespace Minirechner
{
    class Program
    {
        static int Addieren(int Zahl1,int Zahl2)
        {
            int ErgAddition = Zahl1 + Zahl2;
            return ErgAddition;
        }

        static int Subtrahieren(int Zahl1, int Zahl2)
        {
            int ErgAddition = Zahl1 - Zahl2;
            return ErgAddition;
        }

        static int Multiplizieren(int Zahl1, int Zahl2)
        {
            int ErgAddition = Zahl1 * Zahl2;
            return ErgAddition;
        }

        static int Dividieren(int Zahl1, int Zahl2)
        {
            int ErgAddition = Zahl1 / Zahl2;
            return ErgAddition;
        }

        static void Main(string[] args)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;
            int Erg = 0;



            Console.WriteLine("Minirechner-TFO");
            Console.WriteLine();
            Console.Write("Bitte geben Sie die erste Zahl ein: ");
            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie die zweite Zahl ein: ");
            Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
           
            Console.Write("Addieren: "); Console.WriteLine(Addieren(Zahl1, Zahl2));
            
            Console.Write("Subtrahieren: "); Console.WriteLine(Subtrahieren(Zahl1, Zahl2));

            Console.Write("Multiplizieren: "); Console.WriteLine(Multiplizieren(Zahl1, Zahl2));

            Console.Write("Dividieren: "); Console.WriteLine(Dividieren(Zahl1, Zahl2));
            Console.ReadKey();
        }
    }
}

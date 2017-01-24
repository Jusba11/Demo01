using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0, luku;

            do
            {
                
                Console.Write("Anna luku, jos syotat 0 niin ohjelma loppuu >");
                string syote = Console.ReadLine(); // luetaan käyttäjän syöte
                luku = int.Parse(syote); //parsitaan syöttestä luku
                summa = (summa + luku);

            } while (luku != 0);

            Console.Write("Antamiesi lukujen summa on: ");
            Console.WriteLine(summa);
        }
    }
}

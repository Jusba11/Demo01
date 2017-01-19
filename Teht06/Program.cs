using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int ajomatka;
            double kilometrihinta = ((7.02 / 100) * 1.595);
    
            //kulutus 7.02 per 100km
            //bensan hinta 1.595
            Console.Write("Paljoko meinasit ajaa?");
            string syote = Console.ReadLine();
            ajomatka = int.Parse(syote);

            Console.Write("Ajomatkasi tulee maksamaan: ");
            Console.WriteLine(kilometrihinta * ajomatka);
        }
    }
}

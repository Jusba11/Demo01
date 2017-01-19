using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            
            Console.Write("Annappa vuosiluku niin kerron onko se karkausvuosi >");
            string syote = Console.ReadLine();
            vuosi = int.Parse(syote);
            //    4 jaollinen         mutta ei sadalla     tai 400lla
            if ((vuosi % 4) == 0 && vuosi % 100 != 0 || vuosi % 400 == 0) {
                Console.WriteLine("JEP on karkausvuosi");
            }
            else
            {
                Console.WriteLine("NOUP");
            }
        }
    }
}

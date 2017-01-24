using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            Console.Write("Kirjoita jotain niin kerron onko kirjoittamasi asia palidromi>");
            string syote = Console.ReadLine(); // luetaan käyttäjän syöte

            char[] syote_reverse = syote.ToCharArray();
            Array.Reverse(syote_reverse);
            string syote2 = new string(syote_reverse);

            if (syote == syote2)
                {
                    Console.WriteLine("JOOO! Palidromi!");
                }
                else
                {
                    Console.WriteLine("NO EI OLE.");
            
                }
        }
        
    }
}

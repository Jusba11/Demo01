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
            string syote2;

            Console.Write("Kirjoita jotain niin kerron onko kirjoittamasi asia palidromi>");
            string syote = Console.ReadLine(); // luetaan käyttäjän syöte

            char[] syote_reverse = syote.ToCharArray();
            Array.Reverse(syote_reverse);
            new string(syote_reverse);



        }
    }
}

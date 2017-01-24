using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = {1, 2, 33, 44, 55, 68, 77, 96, 100};
            int i;

            for (i = 0; i < luvut.Length; i++)
            {
                if ( luvut[i] % 2 == 0)
                {
                    Console.Write(luvut[i]);
                    Console.WriteLine(" HEP!");
                }
                
            }

        }
        
    }
}

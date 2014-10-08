using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string a = "**";
            while (i<5)

            {
                i++;

                while (j < i)
                {
                   Console.Write(a);
                    a = a + "**";
                    j++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ali Atahan");


        }
    }
}

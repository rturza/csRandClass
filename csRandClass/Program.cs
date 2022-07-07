using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csRandClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(); //instance of random class
            for (int i = 0; i < 10; i++)
                //Console.Write((char)random.Next(65, 122));
                Console.Write((char)('a'+ random.Next(0, 26)));

            Console.WriteLine();
        }
    }
}

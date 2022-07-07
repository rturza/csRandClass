using System;
using System.Runtime.InteropServices;

namespace csRandClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(); //instance of random class
            var buffer = new char[10]; //array to store the rand character

            for (int i = 0; i < 10; i++)
                //Console.Write((char)random.Next(65, 122));
                buffer[i] = (char)('a'+ random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}

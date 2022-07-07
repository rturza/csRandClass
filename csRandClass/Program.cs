using System;

namespace csRandClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(); //instance of random class
            const int passwordLength = 10;
            var buffer = new char[passwordLength]; //array to store the rand character

            for (int i = 0; i < passwordLength; i++)
                //Console.Write((char)random.Next(65, 122));
                buffer[i] = (char)('a'+ random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}

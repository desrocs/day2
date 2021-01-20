using System;

namespace infinityLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i=i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

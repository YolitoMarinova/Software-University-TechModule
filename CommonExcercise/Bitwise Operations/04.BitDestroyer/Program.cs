﻿using System;

namespace _04.BitDestroyer
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;

            mask = ~mask;

            Console.WriteLine(number & mask);
        }
    }
}

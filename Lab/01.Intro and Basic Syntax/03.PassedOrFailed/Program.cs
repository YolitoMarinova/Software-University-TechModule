﻿using System;

namespace _03.PassedOrFailed
{
    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}

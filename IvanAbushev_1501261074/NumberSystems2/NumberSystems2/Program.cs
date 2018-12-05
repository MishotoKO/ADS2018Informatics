﻿using System;

namespace NumberSystems2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary: {0}", result);
            Console.ReadLine();
        }
    }
}

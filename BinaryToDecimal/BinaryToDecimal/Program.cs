﻿using System;
public class BinaryToDecimal
{
    public static void Main()
    {
        int n1, n, p = 1;
        int dec = 0, i = 1, j, d;

        Console.Write("Input a binary number :");
        n = Convert.ToInt32(Console.ReadLine());
        n1 = n;
        for (j = n; j > 0; j = j / 10)
        {
            d = j % 10;
            if (i == 1)
                p *= 1;
            else
                p *= 2;

            dec = dec + (d * p);
            i++;
        }
        Console.Write("\nThe Binary Number : {0}\nThe equivalent Decimal  Number : {1} \n\n", n1, dec);
    }
}
﻿using System;

namespace Bubble_Sort_100_Ordered
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 98, 388, 489, 540, 709, 815, 926, 1206, 1212, 1290,
                1315, 1392, 1435, 1742, 1848, 1872, 1935, 2067, 2119, 2257,
                2306, 2316, 2385, 2464, 2474, 2566, 2665, 2714, 3028, 3092,
                3299, 3435, 3463, 3663, 3784, 3958, 3968, 4299, 4354, 4504,
                4526, 4620, 4803, 5120, 5145, 5149, 5211, 5314, 5351, 5354,
                5375, 5461, 5589, 5667, 5695, 5707, 5852, 5948, 6013, 6041,
                6046, 6069, 6123, 6154, 6327, 6407, 6415, 6422, 6463, 6470,
                6491, 6537, 6560, 6648, 6733, 6902, 7140, 7202, 7377, 7798,
                7845, 7868, 8039, 8242, 8481, 8516, 8707, 8742, 8768, 8916,
                9121, 9410, 9461, 9535, 9608, 9621, 9640, 9772, 9851, 9928 };

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

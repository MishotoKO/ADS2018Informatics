namespace GraphColoring
{
    using System;

    public class Program
    {
        private const int MaxN = 200;

        private const uint N = 5;

        private static readonly int[,] A =
        {
            { 0, 1, 0, 0, 1 },
            { 1, 0, 1, 1, 1 },
            { 0, 1, 0, 1, 0 },
            { 0, 1, 1, 0, 1 },
            { 1, 1, 0, 1, 0 }
        };

        private static readonly uint[] Col = new uint[MaxN];

        private static uint maxCol, count = 0;

        internal static void Main(string[] args)
        {
            uint i;
            for (maxCol = 1; maxCol <= N; maxCol++)
            {
                for (i = 0; i < N; i++)
                {
                    Col[i] = 0;
                }

                NextCol(0);
                if (count > 0)
                {
                    break;
                }
            }

            Console.WriteLine("Общ брой намерени оцветявания с {0} цвята: {1} \n", maxCol, count);
        }

        private static void ShowSol()
        {
            uint i;
            count++;
            Console.WriteLine("Оцветяване на квадрата: ");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Връх {0} - с цвят {1} ", i + 1, Col[i]);
            }
        }

        private static void NextCol(uint i)
        {
            uint k;

            if (i == N)
            {
                ShowSol();
                return;
            }

            for (k = 1; k <= maxCol; k++)
            {
                Col[i] = k;
                uint success = 1;
                for (uint j = 0; j < N; j++)
                {
                    if (1 == A[i, j] && Col[j] == Col[i])
                    {
                        success = 0;
                        break;
                    }
                }

                if (success == 1)
                {
                    NextCol(i + 1);
                }

                Col[i] = 0;
            }
        }
    }
}

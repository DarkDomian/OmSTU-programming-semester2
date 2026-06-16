using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[,] image = {
                { 1,  4,  0 },
                { 9, 2,  11 },
                { -1,  8,  3 }
            };

            int depth = 4;

            char[,,] Bit = new char[3, 3, depth];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string Temp = Convert.ToString(image[i, j], 2);

                    char[] tempBit = Temp.ToCharArray();
                    Array.Reverse(tempBit);

                    for (int k = 0; k < depth; k++)
                    {
                        if (k < tempBit.Length)
                        {
                            Bit[i, j, k] = tempBit[k];
                        }
                        else
                        {
                            Bit[i, j, k] = '0';
                        }
                    }
                }
            }


            Console.WriteLine("Входная матрица (двумерный массив):");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(image[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------\n");


            Console.WriteLine("Вывод трёхмерного массива по битовым слоям:");
            Console.WriteLine("--------------------------------");

            for (int l = 0; l < depth; l++)
            {
                Console.WriteLine($"Слой битов №{l}:");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(Bit[i, j, l] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------");
        }
    }
}
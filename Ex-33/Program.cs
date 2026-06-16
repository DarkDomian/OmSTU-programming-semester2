using System;

namespace JaggedArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[][] jaggedArray = new int[4][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int currentLength = i * 2; 
                jaggedArray[i] = new int[currentLength]; 
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i + j + 1;
                }
            }
            Console.WriteLine($"Количество вложенных массивов (общая длина): {jaggedArray.Length}");
            Console.WriteLine("-----------------------------------------------------");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Внутренний массив №{i} (Длина: {jaggedArray[i].Length}): [ ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }

                Console.WriteLine("]");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Программа успешно завершила работу с jagged-массивом.");
        }
    }
}
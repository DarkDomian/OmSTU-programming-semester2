using System;

namespace MethodOverloading
{
    class Matrix
    {
        public int[,] Mass;
        public Matrix(int rows, int cols)
        {
            Mass = new int[rows, cols];
        }
    }
    class MAS
    {
        public int SUM(int a, int b)
        {
            return a + b;
        }
        public Matrix SUM(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result.Mass[i, j] = first.Mass[i, j] + second.Mass[i, j];
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MAS masObject = new MAS();
            Console.Write("Ввод значения первого числа: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввод значения второго числа: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = masObject.SUM(num1, num2);
            Console.WriteLine($"Пример сложения двух чисел: {num1} + {num2} = {result}");
            Console.WriteLine("--------------------------------------------");
            Matrix M1 = new Matrix(2, 2);
            Matrix M2 = new Matrix(2, 2);
            M1.Mass[0, 0] = 1; M1.Mass[0, 1] = 50;
            M1.Mass[1, 0] = 12; M1.Mass[1, 1] = -5;

            M2.Mass[0, 0] = 9; M2.Mass[0, 1] = -48;
            M2.Mass[1, 0] = 0; M2.Mass[1, 1] = 4;
            Matrix finMatrix = masObject.SUM(M1, M2);
            Console.WriteLine("Проверка сложения матриц (каждый элемент складывается друг с другом):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(finMatrix.Mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
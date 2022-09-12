using System;

namespace task_number_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int n = int.Parse(Console.ReadLine());
            double [,] matrix = new double [m,n];
            Random rand = new Random();

            void FillAndPrintMatrix(double [,] array)
            {
            for (int i = 0; i<m ;i++)
            {
                for (int j = 0; j<n ;j++)
                {
                    matrix [i,j] = Math.Round(rand.Next(1,10)+rand.NextDouble(),2);
                    Console.Write(matrix [i,j]+" ");
                }
                Console.WriteLine();
            }
            }

            FillAndPrintMatrix(matrix);

        }
    }
}

using System;

namespace task_number_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите нужную строку: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите нужный столбец: ");
            int n = int.Parse(Console.ReadLine());
            int [,] matrix = new int [5,5];
            Random rand = new Random();

            void FillAndPrintMatrix(int [,] array)
            {
                for (int i = 0; i<5 ;i++)
                {
                    for (int j = 0; j<5 ;j++)
                    {
                    matrix [i,j] = rand.Next(1,10);
                    Console.Write(matrix [i,j]+" ");
                    }
                Console.WriteLine();
                }
            }

            FillAndPrintMatrix(matrix);
            
            if (n<6 && m<6)
            Console.WriteLine($"Число в строке {m} и столбце {n} = {matrix[m-1,n-1]}");
            else
            {
                Console.WriteLine($"В этой стрице нет элемента в строке {m} столбце {n}.");
            }
        }
    }
}

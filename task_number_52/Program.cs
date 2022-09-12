using System;

namespace task_number_52
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrix = new int [5,5];
            double [] avg = new double [5];
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
            for (int i = 0; i<5 ;i++)
            {
                for (int j = 0; j<5 ;j++)
                {
                    avg[j] += matrix[i,j];
                }
            }

            Console.WriteLine();
            
            for (int j = 0; j<5 ;j++)
            {
                avg[j] = avg[j]/5;
                Console.Write(avg [j]+" ");
            }
        }
    }
}

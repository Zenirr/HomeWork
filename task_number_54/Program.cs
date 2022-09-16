using System;

namespace task_number_54
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrix = new int [5,5];
            double [] avg = new double [5];
            Random rand = new Random();

            
            for (int i = 0; i<5 ;i++)
            {
                for (int j = 0; j<5 ;j++)
                {                    
                matrix [i,j] = rand.Next(1,10);
                Console.Write(matrix [i,j]+" ");
                }
            Console.WriteLine();
            }

            Console.WriteLine();
            
            for (int i = 0; i<matrix.GetLength(0) ;i++)
            {
                for (int j = 0; j<matrix.GetLength(1);j++)
                {                    
                    for (int m = 0; m < matrix.GetLength(1)-1; m++)
                    {
                        if(matrix[i,m]<matrix[i,m+1])
                        {
                            int temp = 0;
                            temp = matrix[i, m];
                            matrix[i, m] = matrix[i, m + 1];
                            matrix[i, m + 1] = temp;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
            
            void PrintMatrix(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            }
        }
    }
}

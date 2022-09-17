using System;

namespace task_number_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int [,] matrix = new int [rand.Next(5,8),rand.Next(3,5)];
            int [] mass = new int [matrix.GetLength(0)];
            int minSumm = 0, minLine = 0;
            
            for (int i = 0; i<matrix.GetLength(0);i++)
            {
                for (int j = 0; j<matrix.GetLength(1);j++)
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
                    mass[i] += matrix[i,j];
                }
            }
            
            minSumm = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if(minSumm>mass[i]){
                minSumm = mass[i];
                minLine = i;
                }
            }

            Console.WriteLine($"Строкой с наимейшей суммой элементов является {minLine+1}");
        }
    }
}

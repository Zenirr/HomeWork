using System;

namespace task_number_37
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] mass = new int [4];
            Random rand  = new Random();
            int result = 0, i = 0, j=3;

            for (int m = 0; m<=3;m++)
            {
                mass [m] = rand.Next(-100,101);
                Console.Write(mass[m]+" ");
            }
            
            Console.WriteLine();
            while (i < j)
            {
                result = mass [i]*mass[j];
                Console.Write($"{result} ");
                i++;
                j--;
            }       
        }
    }
}

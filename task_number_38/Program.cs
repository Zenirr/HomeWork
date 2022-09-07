using System;

namespace task_number_38
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] mass = new double [4];
            Random rand  = new Random();
            double result = 0, max = 0, min=0;

            for (int i = 0; i<=3;i++)
            {
                mass [i] = rand.Next(-100,101);
                Console.Write(mass[i]+" ");
            }
            max = mass [0];
            min = mass [0];
            Console.WriteLine();
            for (int i = 0; i<=3;i++)
            {
                if (max< mass[i])
                max = mass[i];
                
                if (min> mass[i])
                min = mass[i]; 
            }     
            result = max - min;
            Console.WriteLine($"разница между максимальным и минимальным числами в массиве = {result}");    
        }
    }
}

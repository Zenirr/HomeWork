using System;

namespace task_number_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] mass = new int [4];
            Random rand  = new Random();
            int count = 0;

            for (int i = 0; i<=3;i++)
            {
                mass [i] = rand.Next(-100,101);
                Console.Write(mass[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i<=3;i++)
            {
                if ((i%2)!=0)
                count += mass[i];
            }           
            Console.Write("Сумма нечётных элементов массива = "+count);
        }
    }
}

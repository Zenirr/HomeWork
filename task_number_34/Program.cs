using System;

namespace task_number_34
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
                mass [i] = rand.Next(100,1000);
                Console.Write(mass[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i<=3;i++)
            {
                if ((mass[i]%2) == 0)
                {
                    count++;
                }
            }
            
            Console.WriteLine("Число чётных чисел = "+ count);
        }
    }
}

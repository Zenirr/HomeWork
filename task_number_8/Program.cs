using System;

namespace task_number_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число = ");
            int N = Convert.ToInt32(Console.ReadLine());
            string numbers = "";

            for (int i = 1; i<N;i++)
            {
                if ((i%2)==0)
                numbers= numbers+$" {i}";
            }
            Console.WriteLine($"Чётные числа до {N} = {numbers}");
        }
    }
}
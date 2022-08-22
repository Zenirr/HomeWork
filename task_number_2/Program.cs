using System;

namespace task_number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число = ");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число = ");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            if (firstNumb>secondNumb)
            Console.WriteLine($"{firstNumb} больше {secondNumb}");
            else if(secondNumb>firstNumb)
            {
                Console.WriteLine($"{secondNumb} больше {firstNumb}");
            }
            else
            Console.WriteLine("Числа равны")
        }
    }
}

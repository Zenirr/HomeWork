using System;

namespace task_number_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string numbers = Console.ReadLine();
            int result = 0;

            for(int i=0; i<=numbers.Length-1; i++)
            {
                result +=  numbers[i] - '0';
            }
            Console.WriteLine("Сумма чисел = " + result);
        }
    }
}

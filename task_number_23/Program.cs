using System;

namespace task_number_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру : ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i<=number; i++)
            {
                Console.Write(" "+Math.Pow(i,3)+",");
            }
        }
    }
}

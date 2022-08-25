using System;

namespace bonus_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if(((number%7)==0)&&((number%23)==0))
            {
                Console.WriteLine($"Число {number} кратно 7 и 23");
            }
            else
            {
                Console.WriteLine($"Число {number} не кратно 7 и 23");
            }
        }
    }
}

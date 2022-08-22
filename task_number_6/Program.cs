using System;

namespace task_number_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число = ");
            int a =int.Parse(Console.ReadLine());
            
            if ((a%2) ==0)
            Console.WriteLine($"Число {a} чётное");
            else 
            Console.WriteLine($"Число {a} нечётное");
        }
    }
}

using System;

namespace task_number_43
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите b1: ");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите k1: ");
            int k1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите b2: ");
            int b2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите k2: ");
            int k2 = int.Parse(Console.ReadLine());

            double x = (b1-b2)/(k2-k1);
            double y = k2 * x + b2;

            Console.WriteLine($"Точка пересечения двух прямых линий X: {x}; Y: {y}");
        }
    }
}

using System;

namespace task_number_25
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.Write("Введите число которое нужно ввести в степень: ");
            int justNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int degreeNumber = int.Parse(Console.ReadLine());
            int result = 1;

            for(int i = 0;i<degreeNumber;i++)
            {
                result *= justNumber;

            }
            Console.WriteLine("Результата возведения в степень: "+ result);
        }
    }
}

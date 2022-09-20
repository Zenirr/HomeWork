using System;

namespace task_number_66
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите M ");
        int startNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите N ");
        int maxNumber =  Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        PrintNumber(startNumber, maxNumber);

        void PrintNumber(int min, int count)
        {
            if (count < min) return;
            PrintNumber(min, count-1);
            sum += count;
            Console.Write(count + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма = "+ sum);
        }
    }
}

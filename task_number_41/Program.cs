using System;

namespace task_number_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел которые вы хотите ввести: ");
            int elementsCount = int.Parse(Console.ReadLine());
            int [] array = new int [elementsCount];
            int max = 0;

            for(int i = 0;i<array.Length;i++)
            {
                Console.Write($"Введите число под номером {i+1}: ");
                array [i] = int.Parse(Console.ReadLine());
            }

            max = array [0];

            for(int i = 0;i<array.Length;i++)
            {
                if (max<array[i])
                max = array[i];
            }

            Console.WriteLine($"Максимальное число в массиве = {max}"); 
        }
    }
}

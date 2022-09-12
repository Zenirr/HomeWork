using System;

namespace task_number_41
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите числа разделённые пробелом: ");
            string str = Console.ReadLine();
            
            var arrStr =str.Split(" "); 
            
            int [] array = Array.ConvertAll(arrStr, int.Parse);
            int count = 0;

            for(int i = 0;i<array.Length;i++)
            {
                if (array[i]>0)
                count ++;
            }

            Console.WriteLine($"Количество чисел в массиве = {count}");
        }
    }
}

using System;

namespace task_number_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру которая обозначает день недели: ");
            int day = int.Parse(Console.ReadLine());
            
            if((day==7)||(day==6))
            {
                Console.WriteLine("Это выходной");
            }
            else
            {
                Console.WriteLine("Либо это не выходной, либо такого дня недели не существует");
            }

        }
    }
}

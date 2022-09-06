using System;

namespace task_number_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число элементов в массиве: ");
            int elCount = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальное значение элемента в массиве: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Введите минимальное значение элемента в массиве: ");
            int min = int.Parse(Console.ReadLine());
            int [] mass = new int [elCount];
            Random rand  = new Random();
            
            
            Console.Write("[");
            for (int i = 0; i<=elCount-1;i++)
            {
                mass [i] = rand.Next(min,max);
                if(i != elCount-1)
                {
                    Console.Write(mass[i]+", ");
                }
                else
                {
                    Console.Write(mass[i]+"]");
                }
            }
        }
    }
}

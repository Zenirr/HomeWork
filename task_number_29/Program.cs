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
            for (int i = 1; i<=elCount;i++)
            {
                mass [i-1] = rand.Next(min,max);
                if(i-1 != elCount-1)
                {
                    Console.Write(mass[i-1]+", ");
                }
                else
                {
                    Console.Write(mass[i-1]+"]");
                }
            }
        
        }
    }
}

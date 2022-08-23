using System;

namespace task_number_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Введите первое число = ");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число = ");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число = ");
            int thirdtNumb = Convert.ToInt32(Console.ReadLine());
            int max = firstNumb;

            int [] mass  = new int [3] {firstNumb,secondNumb,thirdtNumb};
            int massLenght = 3;

            for (int i = 0;i<massLenght-1;i++ )
            {
                if(max<mass[i+1])
                    max = mass[i+1];
            }

            Console.WriteLine($"Максимальное чилсо = {max}");
        }
    }
}

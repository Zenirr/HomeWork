using System;

namespace bonus_task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTriangleExist(int sideA, int sideB, int sideC)
            {
                
            if(((sideA+sideB)>sideC)&&((sideA+sideC)>sideB)&&((sideC+sideB)>sideA))
            {
                
                return true;
            }
            else
            {
                return false;
            }
            }

            Console.Write("Введите первую сторону треугольника: ");
            int sideA = int.Parse(Console.ReadLine());
            Console.Write("Введите первую сторону треугольника: ");
            int sideB = int.Parse(Console.ReadLine());
            Console.Write("Введите первую сторону треугольника: ");
            int sideC = int.Parse(Console.ReadLine());

            if(isTriangleExist(sideA,sideB,sideC))
            {
                Console.WriteLine("Triangle is exist");
            }
            else
            {
                Console.WriteLine("Triangle doesn't exist");
            }

        }
    }
}

using System;

namespace task_number_21
{
    class Program
    {
        static void Main(string[] args)
        {   
            int [] firstMass= new int [3];
            int [] secondMass= new int [3];
            double coordinates = 0;
            Console.WriteLine("Введите первую координату x1: ");
            firstMass[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первую координату y1: ");
            firstMass[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первую координату z1: ");
            firstMass[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первую координату x2: ");
            secondMass[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первую координату y2: ");
            secondMass[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первую координату z2: ");
            secondMass[2] = int.Parse(Console.ReadLine());

            coordinates = Math.Sqrt((Math.Pow(secondMass[0]-firstMass[0],2)+Math.Pow(secondMass[1]-firstMass[1],2)+Math.Pow(secondMass[2]-firstMass[2],2)));
            Console.Write("Расстояние между точкой = "+ coordinates+" условных единиц");
        }
    }
}

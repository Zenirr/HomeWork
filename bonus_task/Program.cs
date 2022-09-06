using System;

namespace bonus_task
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool isTriangleExist(int sideA, int sideB, int sideC)
            // {
                
            // if(((sideA+sideB)>sideC)&&((sideA+sideC)>sideB)&&((sideC+sideB)>sideA))
            // {
                
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
            // }

            // Console.Write("Введите первую сторону треугольника: ");
            // int sideA = int.Parse(Console.ReadLine());
            // Console.Write("Введите первую сторону треугольника: ");
            // int sideB = int.Parse(Console.ReadLine());
            // Console.Write("Введите первую сторону треугольника: ");
            // int sideC = int.Parse(Console.ReadLine());

            // if(isTriangleExist(sideA,sideB,sideC))
            // {
            //     Console.WriteLine("Triangle is exist");
            // }
            // else
            // {
            //     Console.WriteLine("Triangle doesn't exist");
            // }
        
        // Задача 42: Напишите программу, которая будет преобразовывать
        // десятичное число в двоичное.
        // 45 -> 101101
        // 3 -> 11
        // 2 -> 10

int[] DECtoBIN(int num)
{
    int[] result = new int[32];

    for (int i = 0; num != 0; i++)
    {
        result[result.Length - 1 - i] = num % 2;
        num = num / 2;
    }

    return result;
}

string DECtoBINforSTR(int num)
{
    string result = String.Empty;
    
    for (int i = 0; num != 0; i++)
    {
        result = Convert.ToString(num % 2) + result;
        num = num / 2;
    }

    return result;
}

Console.WriteLine("Enter a integer number...");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"This number is convert to binary from number:\n{String.Join("", DECtoBIN(number))}");

Console.WriteLine($"This number is convert to binary from string:\n{DECtoBINforSTR(number)}");

        }
    }
}

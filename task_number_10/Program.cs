using System;

namespace task_number_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Впишите трёхзначное число:");
            int a = int.Parse(Console.ReadLine());

            if(100 <= a && a <= 999)
            {
            int hundreds = a/100;
            int ones = a%10;
            int res = (a - hundreds*100 - ones)/10;
            Console.WriteLine($"Вторая цифра число {a} = {res}");
            }
            else
            {
                Console.WriteLine($"Число {a} не трёхзначное");
            }
        }
    }
}

using System;

namespace task_number_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пятизначное число: ");
            string strNumbers = Console.ReadLine();
            int intNumbers = int.Parse(strNumbers);
            if ((intNumbers>9999) && (intNumbers<100000))
            {
                if ((strNumbers[0]==strNumbers[4])&& (strNumbers[1]==strNumbers[3]))
                Console.WriteLine("Число "+strNumbers+" полиндром.");
                else
                Console.WriteLine("Число "+strNumbers+" не полиндром");
            }
            else 
            {
                Console.WriteLine("Это не пятизначное число"); 
            }
        }
    }
}

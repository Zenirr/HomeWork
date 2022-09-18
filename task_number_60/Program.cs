using System;

namespace task_number_60
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySizeX = 5;
            int arraySizeY = 3;
            int arraySizeZ = 5;
            int minNumber = 10;
            int maxNumber = 100;
            int[,,] testArray = new int[arraySizeX, arraySizeY, arraySizeZ];
            Random rand = new Random();

            for (int i = 0; i < testArray.GetLength(0); i++)
            {      
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    for (int m = 0; m < testArray.GetLength(2); m++)
                    {
                        while (testArray[i, j, m] == 0)
                        {
                            int number = rand.Next(minNumber, maxNumber + 1);

                            if (IsNumberInMassive(testArray, number) == false)
                            {
                                testArray[i, j, m] = number;
                            }
                        }
                    }      
                }
            }
            
            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    for (int m = 0; m < testArray.GetLength(2); m++)
                    {
                        Console.Write(testArray[i, j, m]);
                        Console.Write($"({i},{j},{m})  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            bool IsNumberInMassive(int[,,] mass, int number)
            {
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        for (int m = 0; m < mass.GetLength(2); m++)
                        {
                            if (mass[i, j, m] == number) return true;
                        }
                    }
                }
                return false;
            }
            
        }
    }
}

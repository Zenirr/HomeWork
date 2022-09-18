using System;

namespace task_number_58
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите количество строк у первой матрицы: ");
        int rowsFirst =Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов у первой матрицы: ");
        int columnsFirst = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество строк у второй матрицы: ");
        int rowsSecond =Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов у второй матрицы: ");
        int columnsSecond = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rowsFirst, columnsFirst];
        int[,] secondMatrix = new int[rowsSecond, columnsSecond];
        int[,] resultMatrix = new int[rowsFirst, columnsSecond];

        FillMassRandom(matrix);
        PrintMass(matrix);

        Console.WriteLine();

        FillMassRandom(secondMatrix);
        PrintMass(secondMatrix);

        Console.WriteLine();

        if (matrix.GetLength(1) != secondMatrix.GetLength(0))
        {
            Console.WriteLine("Нельзя перемножить матрицы");
            return;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
                }
            }
        }

        PrintMass(resultMatrix);

        void FillMassRandom(int[,] massive)
        {
            for (int i = 0; i < massive.GetLength(0); i++)
            {   
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = new Random().Next(1, 10);
                }
            }
        }

        void PrintMass(int[,] massive)
        {
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write($"{massive[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        }
    }
}

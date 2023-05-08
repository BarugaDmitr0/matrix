using System.IO;
using System;

class Program
{
    static void Main()
    {

        int[,] matrix;
        int rows, cols;
        using (StreamReader reader = new StreamReader("C:\\Users\\BarugaDmitr0\\source\\repos\\matrix\\matrix.txt"))
        {
            string[] dimensions = reader.ReadLine().Split();
            rows = int.Parse(dimensions[0]);
            cols = int.Parse(dimensions[1]);

            matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] row = reader.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
        }


        int sum = 0;
        for (int i = 0; i < rows && i < cols; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine("Матриця:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Сума чисел на головнiй дiагоналi: " + sum);
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 5; 

        int[,] matrix = new int[N, N];

        int summa = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = i + j;
                if(i == j)
                    summa += matrix[i, j];
            }
        }

        Console.WriteLine("Матрица, заполненная числами, равными сумме индексов:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine($"Сумма диагональных элементов = {summa}");
    }
}

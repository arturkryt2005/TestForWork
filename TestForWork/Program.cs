    using System;

    class Program
    {
    //static void Main(string[] args)
    //{
    //    int N = 5; 

    //    int[,] matrix = new int[N, N];

    //    int summa = 0;

    //    for (int i = 0; i < N; i++)
    //    {
    //        for (int j = 0; j < N; j++)
    //        {
    //            matrix[i, j] = i + j;
    //            if(i == j)
    //                summa += matrix[i, j];
    //        }
    //    }

    //    Console.WriteLine("Матрица, заполненная числами, равными сумме индексов:");
    //    for (int i = 0; i < N; i++)
    //    {
    //        for (int j = 0; j < N; j++)
    //            Console.Write(matrix[i, j] + " ");
    //        Console.WriteLine();
    //    }

    //    Console.WriteLine($"Сумма диагональных элементов = {summa}");
    //}

    //static void Main(string[] args)
    //{
    //    int[,] matrix = {
    //        { 3, 6, 9 },
    //        { 2, 5, 8 },
    //        { 4, 12, 18 }
    //    };

    //    int rows = matrix.GetLength(0);
    //    int cols = matrix.GetLength(1);

    //    Console.WriteLine("Матрица:");
    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < cols; j++)
    //        {
    //            Console.Write(matrix[i, j] + "\t"); 
    //        }
    //        Console.WriteLine(); 
    //    }

    //    int count = 0;

    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < cols; j++)
    //        {
    //            if (matrix[i, j] % 3 == 0)
    //                count++; 
    //        }
    //    }
    //    Console.WriteLine($"Количество элементов матрицы, которые без остатка делятся на 3: {count}");
    //}
    static void Main(string[] args)
    {
        string str = "This Is A String";
        Console.WriteLine(str);

        int count = 0;

        foreach (char c in str)
        {
            if(c == ' ')  
            count++;
        }
        Console.WriteLine(count);
    }

}

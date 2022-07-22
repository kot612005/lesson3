int[, ] CreateMatr1(int n, int m)
{
    int[, ] matrix1 = new int[n ,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write(matrix1[i, j] + " ");
        }
         Console.WriteLine();
    }
     Console.WriteLine();
    return matrix1;
}

int[, ] CreateMatr2(int m, int n)
{
    int[, ] matrix2 = new int[m ,n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix2[i, j] = new Random().Next(1, 10);
            Console.Write(matrix2[i, j] + " "); 
        }
        Console.WriteLine();
    }
    return matrix2;
}


void CheckMatrix (int[,] matrix1, int[,] matrix2)
{
     Console.WriteLine();
   int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
       for (int j = 0; j < matrix1.GetLength(0); j++)
       {
           result[i,j] = matrix1[i,j] * matrix2[i,j];
            Console.Write(result[i, j] + " \t ");
       }
 Console.WriteLine();
   }
}
CheckMatrix(CreateMatr1(3,3),  CreateMatr2(3,3));
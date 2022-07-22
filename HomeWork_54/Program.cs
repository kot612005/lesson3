int[,] CreateMatr(int n, int m)
{
    int[, ] matrix = new int[n ,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
    return matrix;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        int minPosition = i;
    

        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (array[j]< array[minPosition]) minPosition = j;
        
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

        Console.WriteLine();
    }
}
CheckMatrix(CreateMatr1(3,3));

      
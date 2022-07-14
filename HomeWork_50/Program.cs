int[, ] CreateMatr(int n, int m)
{
    int[, ] matrix = new int[n ,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}
void PrintMatr(int[, ] matrix)
{
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine()); 
if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
    Console.Write("такого числа в массиве нет");
    else
    Console.Write(matrix[i, j]);
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(n, m));


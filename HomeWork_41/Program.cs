Console.Write("Введите 6 чисел: ");
int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
   if  (array[i] > 0)
   count++;
}
Console.WriteLine(count);
int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
   if  (array[i] % 2 == 0)
   count++;
  
}
Console.WriteLine(count);
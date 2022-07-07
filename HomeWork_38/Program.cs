int[] array = new int[7];
int sum  = 0;
int max = 0;
int min = 100;
for (int i = 0; i < 7; i++)
{
   array[i] = new Random().Next(1, 100); 
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
for (int i = 0; i < 7; i++)
{
   if (array [i] > max)
    max = array [i]; 
}
Console.WriteLine (max);
for (int i = 0; i < 7; i++)
{
   if (min > array[i])
    min = array [i]; 
}
Console.WriteLine (min);
Console.WriteLine ("Разница максимального и минимального: "+ (max-min));

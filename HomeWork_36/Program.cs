int[] array = new int[7];
int sum  = 0;
for (int i = 0; i < 7; i++)
{
   array[i] = new Random().Next(1, 100); 
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
for (int i = 0; i < 7; i= i+2)
    {
       sum = sum + array[i];
    }

Console.WriteLine(sum);


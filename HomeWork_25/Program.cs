int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
int count = 1;
while(count < b)
{
    result = result * a;
    count++;
}
Console.WriteLine(result);
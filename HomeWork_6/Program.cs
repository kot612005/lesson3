int n3, n;
int x;
n = new Random().Next(1, 100000000);
Console.WriteLine(n);
while(n>100)
{
    x = n %10;
    n = n / 10;
    if(n<100)
    Console.WriteLine(x);
}
int n1, n2, n;
n = new Random().Next(99, 1000);
Console.WriteLine(n);
n1 = n / 100;
n = n - n1*100;
n2 = n / 10;
Console.WriteLine(n2);
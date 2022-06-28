int n;
n = new Random().Next(1, 7);
Console.WriteLine(n);
if (n % 7 == 6 || n%7 == 0 ){
    Console.WriteLine("yes");
}
else{
    Console.WriteLine("no");
}


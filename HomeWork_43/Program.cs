double b1, b2, k1, k2, x, y;
Console.Write("Введите значения: ");
b1 = Convert.ToDouble(Console.ReadLine());
b2 = Convert.ToDouble(Console.ReadLine());
k1 = Convert.ToDouble(Console.ReadLine());
k2 = Convert.ToDouble(Console.ReadLine());
x = (b1-b2)/(k2-k1);
y = k1 * x + b1;

Console.WriteLine("точка пересечения двух прямых = ");
Console.WriteLine(x);
Console.WriteLine(y);
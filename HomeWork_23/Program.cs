int k;
string w;
Console.WriteLine("определить K \n ");
k = Convert.ToInt16(Console.ReadLine());
w = Convert.ToString(k, 2);
w = w.Replace('1', '5');
Console.WriteLine("К-е по порядку круглое число \n ");
Console.WriteLine(w);
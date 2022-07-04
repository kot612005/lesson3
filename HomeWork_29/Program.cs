int [] array = new int [8];
for( int i = 0; i <= 7; i++)
{ 
    array[i] = new Random().Next(0,8);
}
Console.WriteLine("[" + string.Join (",", array) + "]");
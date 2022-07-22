int f(int n, int m)
{
    if(n != (m - 1))
    return f((n-1),m) + n; 
    return n;
}
int n = 3;
int m = 1;
f(n, m);
Console.Write(f(n,m));



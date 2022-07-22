void f(int n, int m)
{
    if(n != (m - 1))
    {
        f(n - 1, m);
        Console.Write(n + " ");
    }
}

int n = 18;
int m = 7;
f(n, m);

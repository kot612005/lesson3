int A(int n, int m)
{
    if(n == 0) return m + 1;
    if(m == 0) return A(n - 1, m);
    return A (n - 1, A(n, m - 1));
}
int n = 2;
int m = 3;
Console.Write(A(2,3));


Console.WriteLine(factori(5));

int factori(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * factori(n - 1);
    }
}
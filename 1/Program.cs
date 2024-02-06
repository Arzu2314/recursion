void PrintNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{n} ");
        return;
    }
    Console.Write($"{m} ");
    PrintNaturalNumbers(m + 1, n);
}
int m = 5;
int n = 10;
PrintNaturalNumbers(m, n);

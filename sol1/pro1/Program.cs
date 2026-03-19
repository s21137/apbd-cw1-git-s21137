// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Console.WriteLine(Dodaj(1,1));
Console.WriteLine(CalculateAverage([1, 2, 3, 4, 5, 6, 7, 8]));


int Dodaj(int liczba1, int liczba2)
{
    return liczba1 + liczba2;
}
int Odejmij(int liczba1, int liczba2)
{
    return liczba1 - liczba2;
}
int Pomnoz(int liczba1, int liczba2)
{
    return liczba1 * liczba2;
}
int Podziel(int liczba1, int liczba2)
{
    return liczba1 / liczba2;
}
double CalculateAverage(int[] values)
{
    return values.Sum() / (double)values.Length;
}

int CalculateMax(int[] values)
{
    return values.Max();
}
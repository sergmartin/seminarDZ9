// Задача №66
Console.Clear();
string Pechat(int n, int m)
{
    if (n == m)
    {
        return $"{m}";
    }
    return Pechat(n, m - 1) + $" {m} ";
}


Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(Pechat(n, m));
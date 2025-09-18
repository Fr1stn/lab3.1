Console.WriteLine("Введите начальное число (m):");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите конечное число (n):");
double n = Convert.ToDouble(Console.ReadLine());
double S = 0;
double i = m;
while (i <= n)
{
    i += 0.5;
    S += i;
}
Console.WriteLine(S);
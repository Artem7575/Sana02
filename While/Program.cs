Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть натуральне число n: ");
int n = int.Parse(Console.ReadLine());
double sumA = 0;
for (int k = 1; k <= n; k++)
{
    sumA += Math.Pow(-1, k) / (2 * k + 1);
}
Console.WriteLine("a = {0}", sumA);
double sumB = 0;
for (int k = 1; k <= n; k++)
{
    sumB += (1 + 1.0 / Math.Pow(k, 2));
}
Console.WriteLine("b = {0}", sumB);


double sumC = 0;
int f = 1;
for (int k = 1; k <= n; k++)
{
    f = f * k;
    sumC += f;
}
Console.WriteLine("c = {0}", sumC);
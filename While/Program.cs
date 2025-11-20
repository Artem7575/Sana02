Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть натуральне число n: ");
int n = int.Parse(Console.ReadLine());
double sum = 0;
int k = 1;
while (k <= n)
{
    double a = Math.Pow(-1, k) / (2 * k + 1);
    sum += a;
    k++;
}
Console.WriteLine("a = {0}", sum);
double sum2 = 0;
int kc = 1;
while (kc <= n)
{
    double b = (1 + 1/Math.Pow(kc, 2));
    sum2 += b;
    kc++;
}
Console.WriteLine("b = {0}", sum2);
int f = 1;
double sum3 = 0;
int ke = 1;
while (ke <= n)
{
   f = f * ke;
   sum3 += f;
   ke++;
}
Console.WriteLine("c = {0}", sum3);
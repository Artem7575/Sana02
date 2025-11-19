Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть число а:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть число b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть число c:");
int c = int.Parse(Console.ReadLine());
int d = a * a - 4 * (a * c);
Console.WriteLine("Дискримінант = {0}", d);
if (d > 0)
{
    double x1 = (-b - Math.Sqrt(d)) / 2 * a;
    double x2 = (-b + Math.Sqrt(d)) / 2 * a;
    Console.WriteLine("Результат х1 = {0}, x2 = {1}", x1, x2);
}
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть число а:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число c:");
double c = double.Parse(Console.ReadLine());
double d = (b * b) - (4 * (a * c));
Console.WriteLine("Дискримінант = {0}", d);
if (d > 0)
{
    double x1 = (double)(-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (double)(-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("Результат х1 = {0}, x2 = {1}", x1, x2);
}
if (d == 0)
{
    double x = (double)(-b / (2 * a));
    Console.WriteLine("Результат х1 = {0}", x);
}
if (d < 0)
{
    Console.WriteLine("Рішень для даного квадратного рівняння немає");
}

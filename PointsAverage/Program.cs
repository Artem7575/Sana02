Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Вітаю! Введіть 5 оцінок студента(за 100 бальною шкалою)");
int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int three = int.Parse(Console.ReadLine());
int four = int.Parse(Console.ReadLine());
int five = int.Parse(Console.ReadLine());
if ((one + two + three + four + five) / 5 >= 50)
{
    Console.WriteLine("Студент отримав допуск");
}
else {
    Console.WriteLine("Студент не отримав допуску");    
        }

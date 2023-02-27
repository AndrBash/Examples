
Console.WriteLine("Введите число №1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("Максимальное число = ");
    Console.WriteLine(a);
    Console.WriteLine("Минимальное число = ");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Максимальное число = ");
    Console.WriteLine(b);
    Console.WriteLine("Минимальное число = ");
    Console.WriteLine(a);
}
// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число №1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    if(c>a)
    {
        Console.WriteLine("Максимальное число = ");
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine("Максимальное число = ");
        Console.WriteLine(a);
    }
}
else
{
    if(c>b)
    {
        Console.WriteLine("Максимальное число = ");
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine("Максимальное число = ");
        Console.WriteLine(b);
    }
}

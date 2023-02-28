Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Четные числа:");
for(int i = 1; i <= a; i++)
{
    if(i % 2 == 0)
    {
        System.Console.WriteLine(i);
    }    
   
    else
    {
    i = i++;
    }
}    
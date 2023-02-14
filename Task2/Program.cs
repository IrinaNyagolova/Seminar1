int max = 0;

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

if(first > max)
{
    max = first;
}
if(second > max)
{
    max = second;
}
if(third > max)
{
    max = third;
}

Console.WriteLine("max = " + max);

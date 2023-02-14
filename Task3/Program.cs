Console.Write("Введите число: ");
int example = Convert.ToInt32(Console.ReadLine());

int remDiv = example % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

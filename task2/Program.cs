Console.WriteLine("введите число от 1 до 7");
int A = Convert.ToInt32(Console.ReadLine());
if (A == 1) 
{
    Console.WriteLine("Понедельник");
} else
if (A == 2) 
{
    Console.WriteLine("Вторник");
} else
if (A == 3) 
{
    Console.WriteLine("Среда");
} else
if (A == 4) 
{
    Console.WriteLine("Четверг");
} else
if (A == 5) 
{
    Console.WriteLine("Пятница");
} else
if (A == 6) 
{
    Console.WriteLine("Суббота");
} else
if (A == 7)
    Console.WriteLine("Воскресенье");
else
    Console.WriteLine("неверное число");
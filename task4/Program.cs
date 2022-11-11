Console.WriteLine("ВВедите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 100 && a < 1000)
{
    Console.WriteLine(a%10);
}
else
    Console.WriteLine("Число не трехзначное");
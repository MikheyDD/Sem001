Console.WriteLine ("Week days!");
string[] Days = {"Minday","Tuesday","Wensday","Thursday","Friday","Saturday","Sunday"};
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Today is {Days[index-1]}");
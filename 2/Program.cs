//2
Console.WriteLine("Задача 2");
Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
int c = Math.Min(a, b); Console.WriteLine("minimum"); Console.WriteLine(c);
int cc = Math.Max(a, b); Console.WriteLine("maximum"); Console.WriteLine(cc);

//4
Console.WriteLine("Задача 4");
Console.WriteLine("Введите 1 число");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int f = Convert.ToInt32(Console.ReadLine());
int n = Math.Max(d,e);
int g = Math.Max(n,f);
Console.WriteLine(g);

//6
Console.WriteLine("Задача 6");
Console.WriteLine("Введите число");
int h = Convert.ToInt32(Console.ReadLine());
if (h%2 == 0)
{
Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}

//8
Console.WriteLine("Задача 8");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < N)
{
    if (i%2 == 0)
    {
        Console.WriteLine(i);
        i++;
    }
    else
    {
         i++;
    }
}
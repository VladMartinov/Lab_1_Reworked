double x, y, a, cos, sin;

try
{
    Console.WriteLine("Введите значение x");
    x = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение y");
    y = double.Parse(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine("Error!\n Info: " + ex);
    return;
}
cos = Math.Cos(x - (Math.PI / 6));

if (cos <= -1 || cos >= 1)
 Console.WriteLine("Cos в числителе не можит быть больше 1 или меньше -1");
else
{
    sin = Math.Pow(Math.Cos(y), 2);

    if (sin <= 0 || sin >= 1)
        Console.WriteLine("Sin в знаменателе не можит быть больше 1 или меньше 0");
    else
    {
        a = 2 * cos / (1 / 2 + sin);
        Console.WriteLine("Ответ: " + a);
    }
}

Console.WriteLine("\nSecond task...\n");
double z, b;
try
{
    Console.WriteLine("Введите значение z");
    z = double.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Error!\nInfo: " + ex);
    return;
}

b = 1 + (Math.Pow(z, 2) / (3 + Math.Pow(z, 2) / 5));   // z может быть любое число т.к. z∉R
Console.WriteLine("Ответ: " + b);
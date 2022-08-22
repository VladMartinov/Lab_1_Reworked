float angle, h, m;

try
{
    Console.Write("Write the current Hour (<24)...");
    h = float.Parse(Console.ReadLine());

    if (h < 24) { }
    else
    {
        Console.WriteLine("The hour > 24! Error...");
        return;
    };

    Console.Write("Write the current Minuts (<60)...");
    m = float.Parse(Console.ReadLine());

    if(m < 60) {}
    else { 
        Console.WriteLine("The minuts > 60! Error...");
        return;
    };
     
}
catch (Exception ex)
{
    Console.WriteLine("Error! \nInfo: " + ex.Message);
    return;
}

angle = h<=12?(h * 30) + ((float) (m*0.5)): ((h%12) * 30) + ((float)(m * 0.5));

Console.WriteLine("Current angle: " + angle + ".");
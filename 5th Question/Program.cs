float firstLegs, secondLegs, perimeter, square;

try
{
    Console.Write("Write the lengths of 2 legs. First...");
    firstLegs = float.Parse(Console.ReadLine());

    Console.Write("Second...");
    secondLegs = float.Parse(Console.ReadLine());
}
catch (Exception ex)
{ 
    Console.WriteLine("Error!\nInfo: " + ex.Message);
    return; 
}

if(secondLegs <1 || firstLegs < 1)
{
    Console.WriteLine("The cathets cannot be less than or equal to zero!");
    return;
}

perimeter = (float) Math.Sqrt((Math.Pow(firstLegs, 2) + Math.Pow(secondLegs, 2))) + firstLegs + secondLegs;
square = (firstLegs * secondLegs) / 2;

Console.WriteLine("The perimeter: " + perimeter + ".\nThe square: " + square + ".");
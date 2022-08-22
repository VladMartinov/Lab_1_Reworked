double x, result;

try
{
    Console.Write("Enter the value from 'x'... ");
    x = double.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Error!\nInfo: " + ex);
    return;
}

result = (((3 * x - 5) * x + 2) * x - 1) * x + 7;

Console.WriteLine("Result: " + result + ".");
int firstNum, secondNum;

try
{
    Console.Write("Wrote the 1st Number...");
    firstNum = int.Parse(Console.ReadLine());

    Console.Write("Wrote the second Number...");
    secondNum = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Error!\nInfo: " + ex.Message);
    return;
}

Console.WriteLine("Swap...");
firstNum += secondNum;
secondNum = firstNum - secondNum;
firstNum -= secondNum;

Console.WriteLine($"The first number: {firstNum} .\nThe second number: {secondNum} .");
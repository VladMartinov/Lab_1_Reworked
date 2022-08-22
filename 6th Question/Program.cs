Console.Write("Write the number... ");

string lineNum = Console.ReadLine();
char[] charArray = lineNum.ToCharArray();

int product = 1;

try
{
    for (int i = 0; i < charArray.Length; i++)
        product *= int.Parse(charArray[i].ToString());
}
catch (Exception ex)
{
    Console.WriteLine("Error!\nInfo: " + ex.Message);
    return;
}

Console.WriteLine("The result: " + product + ".");
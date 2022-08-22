int Num, reversed;
string stringNum = string.Empty;

try
{
    Console.Write("Enter the number... ");
    Num = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Error!\nInfo: " + ex);
    return;
}

char[] array = Num.ToString().ToCharArray();

for (int i = array.Length - 1; i >= 0; i--)
    stringNum += array[i].ToString();

reversed = int.Parse(stringNum);

Console.WriteLine("Reversed Number: " + reversed + ".");
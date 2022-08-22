namespace _9th_Question
{
    class Program
    {

        static void Main(string[] args)
        {
            double[] aArray = new double[3];
            double[] bArray = new double[3];
            double[] cArray = new double[3];
            double[] dArray = new double[3];

            try
            {
                Console.WriteLine("Enter the values from the a1, a2, a3...");
                for (int i = 0; i < aArray.Length; i++)
                    aArray[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("From b1, b2, b3...");
                for (int i = 0; i < bArray.Length; i++)
                    bArray[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("From c1, c2, c3...");
                for (int i = 0; i < cArray.Length; i++)
                    cArray[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("From d1, d2, d3...");
                for (int i = 0; i < dArray.Length; i++)
                    dArray[i] = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!\nInfo: " + ex);
                return;
            }

            Addition addition = new Addition();

            addition.aSetValues(aArray);
            addition.bSetValues(bArray);
            addition.cSetValues(cArray);
            addition.dSetValues(dArray);

            addition.resultSystem();
        }
    }
}
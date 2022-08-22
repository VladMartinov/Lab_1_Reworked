namespace _1st_Individual_Task
{
    class Individual
    {
        public enum Type
        {
            Legumes, Cereals
        }

        public struct Item
        {
            private string name;
            private Type type;
            private int area;
            private int harvest;

            public void setValues(string name, Type type, int area, int harvest)
            {
                this.name = name;
                this.type = type;
                this.area = area;
                this.harvest = harvest;
            }

            public void printItem()
            {
                Console.WriteLine($"|{this.name,-24}|{this.type,-12}|{this.area,-20}|{this.harvest,-18}|");
            }
        }

        static void printTable(List<Item> list)
        {
            Console.WriteLine(new String('-', 79));
            Console.WriteLine($"{"|Сельско хозяйственные культуры",-78}|");
            Console.WriteLine(new String('-', 79));
            Console.WriteLine($"{"|Наименование",-25}|{"Тип ",-12}|{"Площадь (га)",-20}|{"Урожайность (ц/га)",-15}|");
            Console.WriteLine(new String('-', 79));
            foreach (Item item in list)
            {
                item.printItem();
                Console.WriteLine(new String('-', 79));
            }
            Console.WriteLine($"{"|Перечисляемый тип: Z - зерновые, B - бобовые",-78}|");
            Console.WriteLine(new String('-', 79));
        }

        public static void Main(string[] args)
        {
            List<Item> list = new List<Item>();
            bool flag = true;
            string name = string.Empty;
            char typeStr;
            Type type;
            int area, harvest;

            while (flag)
            {
                bool secondFlag = true;

                try
                {
                    Console.Write("Enter the name... ");
                    name = Console.ReadLine();

                    while (true)
                    {
                        Console.Write("Enter the type... ");
                        typeStr = Console.ReadKey().KeyChar;
                        if (typeStr == 'З')
                        {
                            type = Type.Cereals;
                            break;
                        }
                        else if (typeStr == 'Б')
                        {
                            type = Type.Legumes;
                            break;
                        }
                        else
                            Console.WriteLine("\nWrong type! Try again");
                    }
                    Console.Write("\nEnter the sown area... ");
                    area = int.Parse(Console.ReadLine());

                    Console.Write("Enter the harvest... ");
                    harvest = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!\nInfo: " + ex);
                    continue;
                }

                Item item = new();
                item.setValues(name, type, area, harvest);

                list.Add(item);

                while (secondFlag)
                {
                    Console.WriteLine("Want to add an entry? (\"Yes\" or \"No\")");
                    string answer = Console.ReadLine();

                    if (answer == "Yes" || answer == "No")
                    {
                        if (answer == "No")
                            flag = false;
                        secondFlag = false;
                    }
                    else
                        Console.WriteLine("The wrong value! Try again...");
                }
            }

            printTable(list);
        }
    }
}
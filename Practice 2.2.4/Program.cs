using System;
using _2;
namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string count1 = "go";
            Counter name;
            Console.WriteLine("Выберите начало отсчёта:\n1 - По умолчанию\n2 - Произвольное\n");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {

                name = new Counter();

            }
            else
            {
                Console.WriteLine("Введите начало отсчёта");
                input = Convert.ToInt32(Console.ReadLine());
                name = new Counter(input);
            }

            Console.WriteLine("Введите \"+\" для прибавления к числу единицы\n" +
                              "Введите \"-\" чтобы отнять отнять единицу\n" +
                              "Введите\"c\" чтобы узнать текущее состояние счетчика\n" +
                              "Введите\"exit\" чтобы выйти из счетчика");

            while (count1 != "exit")
            {
                count1 = Console.ReadLine();
                if (count1 == "exit") break;

                switch (count1)
                {
                    case "+":
                        name.Up();
                        break;
                    case "-":
                        name.Down();
                        break;
                    case "c":
                        int res = name.GetCount;
                        Console.WriteLine("Текущее состояние счётчика: " + res);
                        break;
                }

            }
        }
    }
}
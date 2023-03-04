using System;
using _2;

namespace _1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Nums res = new Nums(1, 5);
            

            int input = 0;
            while (input != 5)
            {
                Console.WriteLine("Меню:\n1 - Изменить значения чисел\n2 - Вывести сумму чисел\n3 - Вывести наибольшее из чисел\n4 - Вывести числа\n5 - Выход из программы\n");
                if (input == 5) break;
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        input = 0;
                        res.ChangeNum();
                        break;
                    case 2:
                        res.Sum();
                        break;
                    case 3:
                        res.Bigger();
                        break;
                    case 4:
                        res.ShowNum();
                        break;
                }

            }
        }
    }
}
using System;
using _2;
using System.Collections.Generic;
namespace _1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Train> trains = new List<Train>();
            trains.Add(new Train("Moskva", 15, "07.03.2023"));
            trains.Add(new Train("Tomsk", 13, "15.03.2023"));
            trains.Add(new Train("Kazakhstan", 14, "31.03.2023"));

            int input = 0;
            Console.WriteLine("Меню\nВведите номер поезда или \"0\" для выхода\n");

            while (input != 1)
            {
                string show = "";
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 0) break;
                foreach (Train numTrain in trains)
                {
                    if (numTrain.GetNumber == input)
                    {
                        show = numTrain.ShowTrain();
                        break;
                    }
                }

                if (show != "")
                {
                    Console.WriteLine(show);
                }
                else
                {
                    Console.WriteLine("Такого поезда нет");
                }

            }
        }

    }

}
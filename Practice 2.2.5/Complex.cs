using System;

namespace _2
{

    public class Person
    {
        public int Num1 { get; }

        public int Num2 { get; }


        public Person(int Num1, int Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
        }
        public Person()
        {
            Num1 = 1;
            Num2 = 2;
        }



        ~Person()
        {
            Console.WriteLine($"{Num1} умер");
            Console.WriteLine($"{Num2} умер");
        }
    }
}
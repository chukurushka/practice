using System;
using _2;
namespace _1
{
    public class Program
    {
        public static void Method()
        {
            Person p = new Person();
        }
        static void Main(string[] args)
        {
            Method();
            GC.Collect();

        }
    }
}
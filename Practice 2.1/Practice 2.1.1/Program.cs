using System;
namespace Practice_2._1 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int check = 0;
            string s = Console.ReadLine();
            string j = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                for (int k = 0; k < j.Length; k++)
                {
                    if (s[i] == j[k])
                    {
                        check++;
                    }
                }
            }
            Console.WriteLine(check);
        }
    }
}
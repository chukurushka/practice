using System;
namespace Practice_2._1._3
{
    public class Program
    {
        public static bool DoubleValue(int[] arr)
        {
            int check = 0;
            for(int i =0 ; i < arr.Length; i++)
            {
                for(int j =i+1; j < arr.Length-1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        check++;
                    }
                    else if (check >= 1)
                    {
                        return true;
                    }
                
              
                }
                check = 0;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            int[] array = { 1,1,1,3,3,4,3,2,4,2 };
            bool nums = DoubleValue(array);
            Console.WriteLine(nums);
        }
    }
}
using System;
using System.Collections.Generic;
namespace Practice_2._1._2
{
    public class Program
    {
        public static void Combination2(int l, int sum, int target, List<int> allCandidates,
            List<int> newCandidates)
        {
            if (sum == target)
            {
                Console.Write("[");
                for (int i = 0; i < allCandidates.Count; i++)
                {
                    if (i != 0)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(allCandidates[i]);

                    if (i != allCandidates.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("]");

            }

            for (int i = l; i < newCandidates.Count; i++)
            {
                if (sum + newCandidates[i] > target)
                {
                    continue;
                }

                if (i > l && newCandidates[i] == newCandidates[i - 1])
                {
                    continue;
                }

                allCandidates.Add(newCandidates[i]);
                Combination2(i + 1, sum + newCandidates[i], target, allCandidates, newCandidates);
                allCandidates.RemoveAt(allCandidates.Count - 1);
            }
        }


        public static void Combination(List<int> newCandidates, int target)
        {
            newCandidates.Sort();

            List<int> allCandidates = new List<int>();

            Combination2(0, 0, target, allCandidates, newCandidates);
        }

        public static void Main(string[] args)
        {
            int[] candidates = { 2,5,2,1,2 };
            List<int> newCandidates = new List<int>(candidates);

            int target = 5;

            Combination(newCandidates, target);
        }
    }
}
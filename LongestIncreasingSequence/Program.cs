namespace LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static List<List<int>> sequences = new List<List<int>>();

        static void Main()
        {
            int[] nums = { 1, 2, 3, 5, 0, 6, 17, 16, 33, 1, 5, 9, 90, 111, 1001, 5, 3, 4, 8, 12, 33, 5 };
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> tempNums = new List<int>();
                CheckSequence(i, nums, tempNums);
            }

            Console.WriteLine(string.Join(", ", sequences.OrderByDescending(s => s.Count).FirstOrDefault()));
        }

        static void CheckSequence(int index, int[] nums, List<int> tempNums)
        {
            if (index >= nums.Length)
            {
                AddToCollection(tempNums);
                return;
            }

            if (tempNums.Count > 0 && tempNums.Last() > nums[index])
            {
                AddToCollection(tempNums);
                return;
            }

            tempNums.Add(nums[index]);
            index++;
            CheckSequence(index, nums, tempNums);
        }

        static void AddToCollection(List<int> tempNums)
        {
            if (tempNums.Count > 0)
            {
                sequences.Add(tempNums);
            }
        }
    }
}

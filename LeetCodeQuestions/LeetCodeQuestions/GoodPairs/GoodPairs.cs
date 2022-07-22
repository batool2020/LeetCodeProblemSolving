using System;
namespace LeetCodeQuestions
{
    public class GoodPairs
    {

        public static int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i != j)
                        count++;

                }
            }
            return count/2;

        }

    }
}

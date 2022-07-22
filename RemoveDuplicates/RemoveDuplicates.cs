using System;

namespace LeetCodeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int k = RemoveDuplicates(array);
            Console.WriteLine(k);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            /*

                  int k = 0;

                  for (int i = 0; i < nums.Length; i++)
                  {
                      if (nums[i] != -200)
                      {
                          for (int j=0; j < nums.Length; j++)
                          {
                              if (nums[i] == nums[j] && i!=j)
                              {
                                  nums[j] = -200; 
                                  k++;
                              }
                          }
                      }
                  }


                  for (int i = 0; i < nums.Length; i++)
                  {
                      if (nums[i] == -200)
                      {
                          while (nums[i + 1] != -200)
                          {
                              int temp = i;
                              nums[temp] = nums[i + 1];
                          }
                      }
                  }
                  for (int i = 0; i < nums.Length; i++)
                  {
                      Console.WriteLine(nums[i]);
                  }
                  return k;
             */

            int index = 1;
            int counter = 1;
            int lastnumber = nums[0];
            while (counter < nums.Length)
            {
                if (lastnumber != nums[counter])
                {
                    lastnumber = nums[counter];
                    nums[index] = nums[counter];
                    index++;
                }
                counter++;
            }
            return index;
        }



    }
}

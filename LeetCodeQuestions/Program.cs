using System;
using System.Collections.Generic;

namespace LeetCodeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 1, 1 };
            // int x = 100222001;
            //bool flag = IsPalindrome(x);
            // int result = GoodPairs.NumIdenticalPairs(array);
            // Console.WriteLine(flag);
            (double Sum, int Count) t2 = (4.5, 3);
           // Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

            (double va1, string va2) t1 = (98.3, "Batool");
            Console.WriteLine($"{t1.va2}'s Grade in tawjihi is: {t1.va1}");
            SwapExample();
            OutUsage();

            //Output:
            //Sum of 3 elements is 4.5.

            /* 
             ReversedLinkedList Solution Driver
             int[] array = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int k = RemoveDuplicatess(array);
            Console.WriteLine(k);
             */
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"vlue of i,j is {i},{j}");    // "2 1"
        }

        static void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }

        public static void OutUsage()
        {
            Divide(10, 3, out int res, out int rem);
            Console.WriteLine($"{res} {rem}");  // "3 1"
        }

        public static bool IsPalindrome(int x)
        {
            Boolean flag = false;

            if (x < 0)
                flag = false;
            else if (x == 0)
                flag = true;
            else
            {
                int i = 0;
                List<int> array = new List<int>();
                while (x  != 0)
                {
                    array.Add(x % 10);
                    x = x / 10;
                    i++;
                }
                for (int j = 0; j < i; j++)
                {
                    if (array[j] != array[i - 1 - j])
                    {
                        flag = false; 
                        break;
                    }
                    else
                        flag = true;
                }
            }
            return flag;
        }
    }
}

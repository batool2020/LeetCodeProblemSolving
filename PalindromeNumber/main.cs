using System;
using System.Collections.Generic;

public class Solution {
    public bool IsPalindrome(int x) {
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
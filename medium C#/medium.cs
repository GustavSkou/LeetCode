/*
    238. Product of Array Except itself https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=leetcode-75

    Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
    The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
    You must write an algorithm that runs in O(n) time and without using the division operation.
*/

using System.Formats.Asn1;

public class Solution {
    public int[] ProductExceptSelf(int[] nums)
     {
        int[] answerArray = new int[nums.Length];
        for (int index = 0; index < answerArray.Length; index++)
        {
            answerArray[index] = 1;
        }

        for (int i = 0; i < answerArray.Length; i++)
        {
            for (int n = 0; n < answerArray.Length; n++)
            {
                if (i != n)
                {
                    answerArray[i] = + answerArray[i] * nums[n];
                }
            }           
        }
        return answerArray;
    }
}

public class Program
{
    static void Main()
    {
        Solution algorithm = new Solution();
        foreach (var num in algorithm.ProductExceptSelf([1, 2, 3, 4]))
        {
            Console.WriteLine(num);
        }
    }
}
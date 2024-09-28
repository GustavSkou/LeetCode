public class Solution 
{
/*
    1431. Kids With the Greatest Number of Candies https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/

    There are n kids with candies. You are given an integer array candies, 
    where each candies[i] represents the number of candies the ith kid has, 
    and an integer extraCandies, denoting the number of extra candies that you have.
    
    Return a boolean array result of length n, where result[i] is true if, 
    after giving the ith kid all the extraCandies, they will have the greatest 
    number of candies among all the kids, or false otherwise.
    Note that multiple kids can have the greatest number of candies.
*/
    public List<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int mostCandies = 0, mostCandiesIndex = 0;
        bool[] couldHaveMost = new bool[candies.Length];
        
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= mostCandies)
            {
                couldHaveMost[i] = true;

                if (candies[i] > mostCandies)
                {
                    mostCandies = candies[i];                    
                    mostCandiesIndex = i;
                }

                continue;
            }

            couldHaveMost[i] = false;
        }

        for (int n = 0; n < mostCandiesIndex; n++)
        {        
            couldHaveMost[n] = candies[n] + extraCandies >= mostCandies ? true : false;
        }

        List<bool> result = new List<bool>(couldHaveMost);
        return result;
    }
/*
    1768. Merge Strings Alternately https://leetcode.com/problems/merge-strings-alternately/description/
    
    You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, 
    starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
    Return the merged string.
*/
    public string MergeAlternately(string word1, string word2) 
    {
        char[] mergedString = new char[word1.Length + word2.Length];
        int i = 0, n= 0;
        while (i < word2.Length + word1.Length) 
        {
                if (i < word1.Length) 
                {
                    mergedString[n++] = word1[i];
                }
                if (i < word2.Length) 
                {
                    mergedString[n++] = word2[i];
                }
                i++;
        }
        return new string(mergedString);
    }
/*
    26. Remove Duplicates from Sorted Array https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. 
    The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
    Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
    Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. 
    The remaining elements of nums are not important as well as the size of nums.
*/
    public int RemoveDuplicates (int[] nums) 
    {
        int largestNum = nums[0];
        int numsInRow = 1;
        int nextIndex;

        for (int currentIndex = 0; 0 < nums.Length; currentIndex++)
        {
            nextIndex = currentIndex + 1;

            if (largestNum == nums[nums.Length-1])
            {
                break;
            }

            if (nums[nextIndex] > largestNum)
            {
                largestNum = nums[nextIndex];
                numsInRow++;
                continue;
            }

            for (int seachIndex = nextIndex + 1; seachIndex <= nums.Length; seachIndex++)
            {
                if ( nums[seachIndex] > largestNum)
                {
                    nums[nextIndex] = nums[seachIndex];
                    largestNum = nums[nextIndex];
                    numsInRow++;
                    break;
                }
            }
        }
        return numsInRow;
    }
}

class Program
{
    static void Main(){
        Solution algorithm = new Solution();
        algorithm.KidsWithCandies([2, 3, 5, 1, 3], 3);
        algorithm.MergeAlternately("ab", "pqdasdf");
        algorithm.RemoveDuplicates([1, 2, 2, 2, 4, 6, 7, 8, 8, 8, 9 ]);
    }
}
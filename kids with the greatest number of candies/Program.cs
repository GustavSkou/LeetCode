public class Solution {
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
}

class Progran
{
    static void Main(){
        int[] candies = [2, 3, 5, 1, 3];
        int extraCandies = 3;

        Solution pro = new Solution();
        pro.KidsWithCandies(candies, extraCandies);
    }
}
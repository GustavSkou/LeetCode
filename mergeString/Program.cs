public class Solution {
      public string MergeAlternately(string word1, string word2) {
            char[] mergedString = new char[word1.Length + word2.Length];
            int i = 0, n= 0;
            while (i < word2.Length + word1.Length) {
                  if (i < word1.Length) {
                        mergedString[n++] = word1[i];
                  }
                  if (i < word2.Length) {
                        mergedString[n++] = word2[i];
                  }
                  i++;
            }
            return new string(mergedString);
      }
}

public class Program{
      static void Main() 
      {
            Solution algothim = new Solution();
            Console.WriteLine(algothim.MergeAlternately("ab", "pqdasdf"));
            Console.WriteLine(algothim.MergeAlternately("dhryfts", "yiu"));
            Console.WriteLine(algothim.MergeAlternately("hj-", "e:)"));
      }
}
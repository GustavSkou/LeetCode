#include <string>
#include <unordered_map>

using namespace std;

class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        unordered_map<char, int> substringHashMap;
        int substringStart = 0, longestSubstring = 0;
        char currentLetter;

        for(int substringEnd = 0; substringEnd < s.size(); ++substringEnd)                  /* loop bruges til at gøre sliding window større */
        {
            currentLetter = s[substringEnd];
            if (substringHashMap.count(currentLetter) != 0 && substringHashMap[currentLetter] >= substringStart) /* Hvis char er indenfor sliding window */
            {
                substringStart = substringHashMap[currentLetter];                           /* sliding window's start rykkes frem så vi starter fra det fundne char */
            }
            
            substringHashMap[currentLetter] = substringEnd + 1;                             /* Det nyeste tilføjet char får værdien som enden af sliding window */
            longestSubstring = max(longestSubstring, substringEnd - substringStart + 1);
        }

        return longestSubstring;
    }
};
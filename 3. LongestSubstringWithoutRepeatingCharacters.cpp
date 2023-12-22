#include <string>
#include <iostream>

using namespace std;

class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        string currentSubstring;
        int longestSubstring = 0;

        for(int index = 0; index < s.size(); ++index)
        {
            if (currentSubstring.find(s[index]) != string::npos)
            {
                if(currentSubstring.find(s[index]) != 0)
                {
                    currentSubstring.erase(0, currentSubstring.find(s[index]) + 1);
                }
                else
                {
                    currentSubstring.erase(0, 1);
                }
            }

            currentSubstring = currentSubstring + s[index];
            
            if(currentSubstring.size() > longestSubstring)
            {
                longestSubstring = currentSubstring.size();
            }
        }
        return longestSubstring;
    }
};
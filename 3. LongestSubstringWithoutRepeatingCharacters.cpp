#include <string>
#include <iostream>
#include <unordered_map>

using namespace std;

class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        unordered_map<char, int> substringHashMap;
        int substringLength = 0;
        int longestSubstring = 0;

        for(int index = 0; index < s.size(); ++index)
        {
            char currentLetter = s[index];
            
                if (substringHashMap.find(currentLetter) != substringHashMap.end())
                {
                    if(substringHashMap.at(currentLetter) != 0)
                    {
                        substringHashMap.erase(substringHashMap.begin(), substringHashMap.find(currentLetter));
                        substringLength = substringLength - substringHashMap.at(s[index]);
                        //currentSubstring.erase(0, currentSubstring.find(s[index]) + 1);
                    }
                    else
                    {
                        substringHashMap.erase(substringHashMap.begin());
                        --substringLength;
                    }
                }
            
            
            substringHashMap.insert({s[index], substringLength});
            ++substringLength;

            if(substringLength > longestSubstring)
            {
                longestSubstring = substringLength;
            }
        }
        return longestSubstring;
    }
};

int main(){
    string s = "abcabcds";

    Solution someString;
    cout << someString.lengthOfLongestSubstring(s);
    return 0;
}
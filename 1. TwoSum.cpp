#include <vector>
#include <iostream>
#include <unordered_map>
using namespace std;

class Solution {
public:
      vector<int> twoSum(vector<int> nums, int target) 
      {
            unordered_map< int, int > hashmap;
            vector<int> resulte;

            for (int i = 0; i < nums.size(); ++i)
            {
                  hashmap.insert({ nums[i] , i });
            }
            for (int i = 0; i < nums.size(); ++i)
            {
                  int otherNum = target - nums[i];

                  if (hashmap.find(otherNum) == hashmap.end())
                  {
                        continue;
                  }
                  if (hashmap.at(otherNum) == i)
                  {
                        continue;
                  }
                  resulte.push_back(i);
                  resulte.push_back(hashmap.at(otherNum));
                  return resulte;
            }
      }
};

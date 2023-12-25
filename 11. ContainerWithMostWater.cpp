#include <unordered_map>
#include <vector>
#include <iostream>
using namespace std;

class Solution {
      public:     
      int maxArea(vector<int>& height) 
      {
            int left = 0, right = height.size()-1, maxContainerSize = 0, containerSize;

            for(int i = 0; i < height.size()-1; ++i)
            {
                  containerSize = (right - left) * min(height[left], height[right]);
                  maxContainerSize = max(maxContainerSize, containerSize);

                  if (height[left] >= height[right])
                  {
                        --right;
                  }
                  else
                  {
                        ++left;
                  }
            }

            return maxContainerSize;
      }
};


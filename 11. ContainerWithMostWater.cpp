#include <unordered_map>
#include <vector>
#include <iostream>
using namespace std;

class Solution {
      public:     
      int maxArea(vector<int>& height) 
      {
            vector<int> maxContainerIndex;
            int left = 0, right = height.size()-1, maxContainerSize = 0, containerSize;

            for(int i = 0; i < height.size()-1; ++i)
            {
                  containerSize = (right - left) * min(height[left], height[right]);
                  
                  if (height[left] >= height[right])
                  {
                        --right;
                  }
                  else
                  {
                        ++left;
                  }

                  maxContainerSize = max(maxContainerSize, containerSize);
            }
            return maxContainerSize;
      }
};

int main(int argc, char const *argv[])
{
      vector<int> height = {4,4,2,11,0,11,5,11,13,8};
      Solution testcase;
      cout << testcase.maxArea(height);
      return 0;
}

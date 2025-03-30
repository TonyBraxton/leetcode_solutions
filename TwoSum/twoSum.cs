#include <stdio.h>
#include <stdint.h>
#include <limits.h>

int main()
{
  int[] nums = [2,7,11,15];
        int target = nums[0]+nums[1];
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=0; j<nums.Length; j++)
            {
                if(nums[i] + nums [j] == target)
                {
                    int[]myArray = [i, j];
                    return myArray;
                }
                else
                {
                    int[] secondArray =[0,1];
                    return [];
                }
            }
        }
        return 0;
}

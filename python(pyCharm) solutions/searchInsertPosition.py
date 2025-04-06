#Given a sorted array of distinct integers and a target value, return the index if the target is
#found. If not, return the index where it would be if it were inserted in order.
#You must write an algorithm with O(log n) runtime complexity.
class Solution(object):
    def searchInsert(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        expected_index=0
        for i in nums:
            if i==target:
                return nums.index(i)
            else:
                if i<target:
                    expected_index=nums.index(i)+1
        return expected_index
#sample test case
nums=[12,12,16,21]
target=13
sol=Solution()
sol = sol.searchInsert(nums, target)
print(sol)
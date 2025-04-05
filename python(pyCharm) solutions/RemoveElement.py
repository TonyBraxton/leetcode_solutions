#Given an integer array nums and an integer val, remove all occurrences
# of val in nums in-place. The order of the elements may be changed.
# Then return the number of elements in nums which are not equal to val.
class Solution(object):
    def removeElement(self, nums, val):
        """
        :type nums: List[int]
        :type val: int
        :rtype: int
        """
        for i in nums:
            if i == val:
                count = nums.count(i)
                while count > 0:
                    nums.remove(i)
                    count=count-1
        k=len(nums)
        return k
#sample test case below
nums=[1,3,3,3,4,5,5]
val=3
sol=Solution()
sol=sol.removeElement(nums,val)
print(sol)
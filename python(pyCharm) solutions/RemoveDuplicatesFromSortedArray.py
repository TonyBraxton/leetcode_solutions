# nums=[1,2,2,5]
# print(nums.count(4))
# nums.remove(2)
# print(nums)
class Solution(object):
    def removeDuplicates(self, nums):
        for i in nums:
            count = nums.count(i)
            while count > 1:
                nums.remove(i)
                count=count-1
        return nums
#sample example with the nums list below
nums=[1,1,1,1,2,2,2,2]
func=Solution()
result = func.removeDuplicates(nums)
k=len(nums)
print(result)
print(nums[:k])

#You are given a large integer represented as an integer array digits, where each digits[i] is
# the ith digit of the integer. The digits are ordered from most significant to least significant
#in left-to-right order. The large integer does not contain any leading 0's. Increment the large integer by one
# and return the resulting array of digits.

class Solution(object):
    def plusOne(self, digits):
        """
        :type digits: List[int]
        :rtype: List[int]
        """
        strDigits=""
        for i in digits:
            strDigits=strDigits+strDigits.join(str(i))
        strDigits=int(strDigits)+1
        strDigits = str(strDigits)
        arr=[0]*len(strDigits)
        for i in range(0, len(strDigits)):
            arr[i]=int(strDigits[i])
        return arr


digits=[9,9]
sol=Solution()
sol=sol.plusOne(digits)
print(sol)
#Given two binary strings a and b, return their sum as a binary string.
class Solution(object):
    def addBinary(self, a, b):
        """
        :type a: str
        :type b: str
        :rtype: str
        """
        val1=0
        val2=0
        length_a = len(a) - 1
        length_b=len(b)-1
        for i in a:
            val1=val1+(int(i)*2**(length_a))
            length_a = length_a-1
        for j in b:
            val2 = val2 + (int(j) * 2 ** (length_b))
            length_b = length_b - 1
        output=val1+val2
        print(val1)
        print(val2)
        print(output)
        binVal=""
        ans="0"
        while(output>=1):
            remainder = output % 2
            output=int(output/2)
            binVal=binVal+str(remainder)
            ans=binVal[::-1]
        return ans

a="0"
b="0"
sol=Solution()
sol=sol.addBinary(a, b)
print(sol)
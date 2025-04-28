class Solution(object):
    def addBinary(self, a, b):
        """
        :type a: str
        :type b: str
        :rtype: str
        """
        sum = int(a + b)
        bNumber = ""
        while sum >= 1:
            mod = int(sum % 2)
            bNumber = bNumber + (str(mod))
            sum = sum / 2
        return bNumber[::-1]

a="1"
b="11"
sol=Solution()
sol=sol.addBinary(a, b)
print(sol)
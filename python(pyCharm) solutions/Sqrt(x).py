#Given a non-negative integer x, return the square root of x rounded down to the nearest integer.
# The returned integer should be non-negative as well.
# You must not use any built-in exponent function or operator.
#For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.

class Solution(object):
    def mySqrt(self, x):
        """
        :type x: int
        :rtype: int
        """
        Sqrt = 0.1
        result=1
        while result != int(Sqrt):
            Sqrt = Sqrt + 0.1
            Sqrt = round(Sqrt, 1)
            result = x / Sqrt
            result = int(result)
        return int(Sqrt)
        # print(Sqrt)

        # for i in range(0, 100):
        #     Sqrt = Sqrt + 0.1
        #     Sqrt=round(Sqrt,1)
        #     result=x/Sqrt
        #     result=int(result)
        #     if result==int(Sqrt):
        #         return int(Sqrt)
x=4
sol= Solution()
sol=sol.mySqrt(x)
print(sol)
#Given a string s consisting of words and spaces, return the length of the last word in the string.
#A word is a maximal substring consisting of non-space characters only.

class Solution(object):
    def lengthOfLastWord(self, s):
        """
        :type s: str
        :rtype: int
        """
        yes=''
        newStr=s.split(" ")
        print(newStr)
        for i in newStr:
            if i!=" " and i!='':
                arr=i
        return len(arr)
#sample test
s="Hey I am "
sol=Solution()
sol=sol.lengthOfLastWord(s)
print(sol)

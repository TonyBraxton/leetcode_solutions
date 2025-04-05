#Given two strings needle and haystack, return the index of the first occurrence of needle in
# haystack, or -1 if needle is not part of haystack.
class Solution(object):
    def strStr(self, haystack, needle):
        """
        :type haystack: str
        :type needle: str
        :rtype: int
        """
        if haystack.__contains__(needle):
            for i in range (0, len(haystack)):
                if haystack[i:i+len(needle)] == needle:
                    return i
        return -1

#sample test of haystack and needle strings
haystack="mississippi"
needle="issip"
sol=Solution()
sol=sol.strStr(haystack, needle)
print(sol)
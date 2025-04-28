#Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if
#The input string is valid. An input string is valid if:
#Open brackets must be closed by the same type of brackets.
#Open brackets must be closed in the correct order.
#Every close bracket has a corresponding open bracket of the same type.

class Solution(object):
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        bracketOpen = ['(', '{', '[']
        bracketClose = [')', '}', ']']
        open=True
        openCount=0
        closeCount=0
        openIndex=""
        closeIndex=0
        indexCount=0
        for i in s:
            if bracketOpen.__contains__(i):
                openIndex=openIndex+openIndex.join(str(bracketOpen.index(i)))
                openCount=openCount+1
                if indexCount == len(s) - 1:
                    if openCount == closeCount:
                        return True
                    else:
                        return False
            elif bracketClose.__contains__(i):
                closeIndex=bracketClose.index(i)
                closeCount=closeCount+1
                if open == True:
                    if str(closeIndex)!=openIndex[-1:]:
                        return False
                    elif str(closeIndex)==openIndex[-1:]:
                        #open=False
                        if openIndex != []:
                            openIndex = openIndex[:-1]
                        if indexCount==len(s)-1:
                            if openCount==closeCount:
                                return True
                            else:
                                return False
            indexCount = indexCount + 1

myString="(([]){})"
Sol = Solution()
Sol=Sol.isValid(myString)
print(Sol)
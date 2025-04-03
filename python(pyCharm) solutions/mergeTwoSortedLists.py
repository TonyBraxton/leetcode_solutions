
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution(object):
    def mergeTwoLists(self, list1, list2):
        """
        :type list1: Optional[ListNode]
        :type list2: Optional[ListNode]
        :rtype: Optional[ListNode]
        """
        dummy = ListNode()#initial node of mergeList with no value(so it acts just as a representative node to start from
        # somewhere
        current = dummy #setting current to the memory location of dummy(creates a reference pointer;read variable
        # assignment below to understand
        while list1 and list2: #while list 1 and list 2 are not empty (note condition is only valid as long as
            # both of them are not empty)
            if list1.val < list2.val:
                current.next = list1
                list1 = list1.next #because there is no for loop iteration as
            else:
                current.next = list2
                list2 = list2.next
            current = current.next
        if list1:
            current.next=list1
        elif list2:
            current.next=list2
        return dummy.next


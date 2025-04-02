class Solution(object):
    def mergeTwoLists(self, list1, list2):
        """
        :type list1: Optional[ListNode]
        :type list2: Optional[ListNode]
        :rtype: Optional[ListNode]
        """
        list1 = [1, 2, 4]
        list2 = [1, 3, 5]
        list3 = []
        # print(f'length:{len(list3)}')
        for i in range(0, len(list1)):
            if self.head is None:
                self.head = self.ListNode(list1[i])
                list3.remove(list3[i])
        print(list3)
        # Create an instance of the Solution class


solution = Solution()

# Call the mergeTwoLists method (passing in any arguments for the parameters)
solution.mergeTwoLists([],[])  # Arguments for list1 and list2


# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
#
#
# class Solution(object):
#     def mergeTwoLists(self, list1, list2):
#         """
#         :type list1: Optional[ListNode]
#         :type list2: Optional[ListNode]
#         :rtype: Optional[ListNode]
#         """
#         # Initialize a dummy node and a current pointer
#         dummy = ListNode()
#         current = dummy
#
#         # Traverse through both lists and merge them
#         while list1 and list2:
#             if list1.val < list2.val:
#                 current.next = list1
#                 list1 = list1.next
#             else:
#                 current.next = list2
#                 list2 = list2.next
#
#             # Move the current pointer to the next node
#             current = current.next
#
#         # If one of the lists is not empty, attach the remaining nodes
#         if list1:
#             current.next = list1
#         elif list2:
#             current.next = list2
#
#         # Return the merged list starting from the next of the dummy node
#         return dummy.next
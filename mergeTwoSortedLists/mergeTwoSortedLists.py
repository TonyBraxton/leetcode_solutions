
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
        return dummy.next  # remember dummy is just a node with no value or data when we initiate dummy=listNode()
        #so we endup printing dummy.next as it points to the first node in current(current.next of first iteration
        # since current=dummy(we could have returned dummy if it was a real node(if it held an actual value) as it references
        #the node at the start of the list but since it doesn't hold a value here we return dummy.next which points to the
        # second node hence will return whole linkedlist starting from second node.
        # to the next current node in the first if statement is connected to the current node of list1 during each
        # iteration

list1=[1,2,3]
list2=[1,4,5]
solution = Solution()
print(solution.mergeTwoLists(list1, list2))


# In Python, when we assign one variable to another (like current = dummy), both variables will refer to the
# same object in memory. However, when we perform assignments such as current = current.next, the variable current
# itself is being reassigned to a different object (i.e., current.next). It doesn't modify the object that dummy
# points to. Let me explain how this works in the context of your question.



            #current new_node = to next node after each iteration (that is the value passed
#from list1 or list2 and) as such in the next iteration we assign the .next value in the next iteration so that
#we keep incrementing. we need to assign the new_node to the most recent assigned .next node after each iteration
# else we will just be changing new_node.next value without adding any more elements to the mergelist as we are iterating



#note new node is just empty at start
# list1 and list2 are not actually lists, but rather linked lists(of ListNode objects). Each element of list1
# and list2 is a ListNode object, and each ListNode has two main attributes:
# val: stores the value of that node.
# next: points to the next node in the
# linked list( or None if 's the last node).

#list1: In this case, list1 is a reference (or pointer) to the first node in the linked list.
# It doesn’t directly hold a list of values, but rather it holds a reference to the first node, which contains
#a value and same goes for list2




# Call the mergeTwoLists method (passing in any arguments for the parameters)


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
// Solution to Remove Nth Node From End of List problem on LeetCode
// Time Complexity:  O(N + n) where N is the number of nodes in list
// Space Complexity: O(1)

/* Definition for singly-linked list. */
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode c = head;
        var nodeCount = 1;

        while(c.next != null) {
            c = c.next;
            nodeCount++;
        }

        if ((nodeCount - n) == 0) {
            return (head.next != null) ? head.next : null;
        }

        c = head;
        for (int i = 0; i < (nodeCount - n - 1); i++) {
            c = c.next;
        }

        if (c.next == null) {
            return null;
        } else if (c.next.next == null) {
            c.next = null;
        } else {
            c.next = c.next.next;
        }

        return head;
    }
}
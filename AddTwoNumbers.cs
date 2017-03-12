// Solution to AddTwoNumbers problem on LeetCode
// Time Complexity:  O(N)
// Space Complexity: O(N) *Note: can probably be optimized to O(1)

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        if (l1 == null && l2 == null && carry == 0) return null;
        
        var tempNode1 = new ListNode(l1 != null ? l1.val : 0);
        tempNode1.next = (l1 != null ? l1.next : null);

        var tempNode2 = new ListNode(l2 != null ? l2.val : 0);
        tempNode2.next = (l2 != null ? l2.next : null);

        var totalVal = (tempNode1.val + tempNode2.val + carry) % 10;
        var carryOver = (tempNode1.val + tempNode2.val + carry) / 10;

        var sumListNode = new ListNode(totalVal);
        sumListNode.next = AddTwoNumbers(tempNode1.next, tempNode2.next, carryOver);
        
        return sumListNode;
    }
}
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        // Create a dummy node to simplify the code
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        // If one of the lists is exhausted, link the rest of the other list
        if (l1 != null)
        {
            current.next = l1;
        }
        if (l2 != null)
        {
            current.next = l2;
        }

        // The merged list starts from the next of the dummy node
        return dummy.next;
    }

}
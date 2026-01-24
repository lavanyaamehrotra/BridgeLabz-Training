public class Solution{
    public ListNode DeleteDuplicates(ListNode head){
        // Start from head
        ListNode current = head;
        while(current != null && current.next != null){
            // If duplicate found, skip next node
            if(current.val == current.next.val){
                current.next = current.next.next;
            }
            else{
                current = current.next;
            }
        }
        return head;
    }
}

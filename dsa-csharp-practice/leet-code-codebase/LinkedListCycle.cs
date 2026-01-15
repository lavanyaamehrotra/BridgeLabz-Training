/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode times = head;
        double cycle = Math.Pow(10,4);
        for(double i =0;i<cycle+1;i++){
            if(times==null){
                return false;
            }
            times = times.next;
        }
        return true;
    }
}
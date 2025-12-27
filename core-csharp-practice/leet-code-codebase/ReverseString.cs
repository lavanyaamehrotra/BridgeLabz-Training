public class Solution {
  public void ReverseString(char[] s) {
    int left = 0;
    int right = s.Length - 1;
    while (left < right) {
      char temp = s[left];
      s[left] = s[right];
      s[right] = temp;
      left++;
      right--;
    } 
  }
}
//problem number 344 done on leetcode 
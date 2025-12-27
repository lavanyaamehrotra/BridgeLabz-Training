public class Solution {
  public int FirstUniqChar(string s) {
    int[] count = new int[26];
    // Count frequency of each character
    for (int i = 0; i < s.Length; i++) {
      count[s[i] - 'a']++;
    }
    // Find first index whose count is 1
    for (int i = 0; i < s.Length; i++) {
      if (count[s[i] - 'a'] == 1){
        return i;
      }
    }
    return -1;
  }
}
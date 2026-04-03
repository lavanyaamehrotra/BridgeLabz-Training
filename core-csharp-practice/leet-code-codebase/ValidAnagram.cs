public class Solution {
  public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length){
      return false;
    }
    int[] count = new int[26];
    for (int i = 0; i < s.Length; i++) {
      count[s[i] - 'a']++;
      count[t[i] - 'a']--;
    }
    // If all counts are 0, they are anagrams
    for (int i = 0; i < 26; i++) {
      if (count[i] != 0){
        return false;
      }
    }
    return true;
  }
}
//problem number 242 on leetcode

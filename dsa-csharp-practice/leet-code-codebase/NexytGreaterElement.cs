public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        int[] ans = new int[n1];
        int idx = 0;

        for (int i = 0; i < n1; i++){
            idx = Array.IndexOf(nums2, nums1[i]);

            if (idx == n2 - 1){
                ans[i] = -1;
                continue;
            }
            
            for (int j = idx + 1; j < n2; j++){
                if (nums2[j] > nums2[idx]){
                    ans[i] = nums2[j];
                    break;
                }

                ans[i] = -1;
            }
        }

        return ans;
    }
}
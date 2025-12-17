class Solution {
    public int[] twoSum(int[] nums, int target) {
        // to calculate the total of element in the array 
        int n=nums.length;
        //outer loop + inner loop should be equal to the target 

          for(int i=0;i<n-1;i++){
            for(int j=i+1;j<n;j++){
                if(nums[i]+nums[j]==target){
                    // if the ar equal then return the index of the elements 
                    return new int [] {i,j};
                }
            }
        }
        // if no elements found then return nothing 
        return new int [] {};
    }
}
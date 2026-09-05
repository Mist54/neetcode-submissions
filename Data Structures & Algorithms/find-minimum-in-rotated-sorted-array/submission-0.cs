public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int result = 0;
        //Binary search works only/best on sorted lists
        while(left<right){
            int mid = left + (right-left)/2;
            if(nums[mid]>nums[right]){
                left = mid+1;
            }
            else{
                right = mid;
            }
           
        }
        result = nums[left];
        return result;
        
    }
}

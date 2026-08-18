public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        int[] resArray = new int[length];
        resArray[0] = 1;
        for (int i = 1; i < length; i++) 
        {
            resArray[i] = resArray[i - 1] * nums[i - 1];
        }
        int rightProduct = 1;
        for (int i = length - 1; i >= 0; i--) 
        {
            resArray[i] = resArray[i] * rightProduct;
            rightProduct = rightProduct * nums[i];
        }
        return resArray;
    }
}

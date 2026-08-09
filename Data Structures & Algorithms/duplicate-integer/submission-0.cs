public class Solution {
    public bool hasDuplicate(int[] nums) { // Changed 'H' to lowercase 'h'
        Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                return true;
            }
        }

        return false;
    }

    private void Sort(int[] nums) {
        int n = nums.Length;

        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - 1 - i; j++) {
                if (nums[j] > nums[j + 1]) {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
    }
}
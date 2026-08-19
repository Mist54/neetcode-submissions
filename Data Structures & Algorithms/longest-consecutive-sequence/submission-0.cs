public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];

            if (!numSet.Contains(num - 1)) {
                int count = 1;

                while (numSet.Contains(num + 1)) {
                    count++;
                    num++;
                }
                longest = Math.Max(longest, count); 
            }
        }
        return longest; 
    }
}

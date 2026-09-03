public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int currentHeight = 0;
        int currentArea = 0;
        int width = 0;
        int left = 0;
        int right = heights.Length - 1;
        while(left<right){
            width = right - left;
            currentHeight = Math.Min(heights[left],heights[right]);
            currentArea = currentHeight * width;
            maxArea = Math.Max(maxArea,currentArea);
            if(heights[left] < heights[right]){
                left++;
            }
            else{
                right--;
            }

            
        }
        return maxArea;
    }
}

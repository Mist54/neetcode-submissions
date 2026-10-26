public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach(int num in nums){
            if(counts.ContainsKey(num)){
                counts[num]++;
            }
            else{
                counts[num] = 1;
            }
        }
        return counts
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();
        
    }
}

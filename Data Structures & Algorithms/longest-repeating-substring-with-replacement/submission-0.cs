public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] charCounts = new int[26];
        int left = 0;
        int maxFrequency = 0;
        int maxLength = 0;
        for (int right = 0; right < s.Length; right++){
            int rightCharIndex = s[right] - 'A';
            charCounts[rightCharIndex]++;
            maxFrequency = Math.Max(maxFrequency, charCounts[rightCharIndex]);

            int windowLength = right - left + 1;
            if (windowLength - maxFrequency > k){
                int leftCharIndex = s[left] - 'A';
                charCounts[leftCharIndex]--;
                left++;
                
            }
            maxLength = Math.Max(maxLength, right - left + 1);


        }
        return maxLength;
        
    }
}

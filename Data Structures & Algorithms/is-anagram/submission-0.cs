public class Solution {
    public bool IsAnagram(string s, string t) {
      if (s.Length != t.Length) return false;

      int[] CCount = new int[26];
      for(int i=0;i<s.Length;i++){
        CCount[s[i]-'a']++;
        CCount[t[i]-'a']--;
      }

      foreach (int count in CCount) {
            if (count != 0) {
                return false;
            }
        }
        return true;
    }
}

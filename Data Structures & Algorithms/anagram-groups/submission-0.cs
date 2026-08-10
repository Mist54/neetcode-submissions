public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach (string word in strs) {
            char[] characters = word.ToCharArray();
            Array.Sort(characters);
            string sortkey = new string(characters);

            if (!map.ContainsKey(sortkey)) {
                map[sortkey] = new List<string>();
            }

            map[sortkey].Add(word);
        }
        return new List<List<string>>(map.Values);
        
    }
}

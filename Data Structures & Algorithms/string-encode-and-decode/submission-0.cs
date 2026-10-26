public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded = new StringBuilder();
        for(int i=0;i<strs.Count;i++){
            int length = strs[i].Length;
            encoded.Append(length);
            encoded.Append("#");
            encoded.Append(strs[i]);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while(i<s.Length){
            int slashIndex = s.IndexOf('#',i);
            int length = int.Parse(s.Substring(i,slashIndex-i));
            i = slashIndex+1;
            string res = s.Substring(i,length);
            result.Add(res);
            i = i+length;
        }
        return result;

   }
}

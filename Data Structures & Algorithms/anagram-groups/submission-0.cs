public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++){
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedS = new string(charArray);
            if(!result.ContainsKey(sortedS)){
                result[sortedS] = new List<string>();
            }
            result[sortedS].Add(strs[i]);
        }
        return result.Values.ToList<List<string>>();
    }
}

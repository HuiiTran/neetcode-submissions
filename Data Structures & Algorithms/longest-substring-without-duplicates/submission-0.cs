public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<int> set = new HashSet<int>();
        int l = 0;
        int result = 0;
        for(int r = 0; r < s.Length; r++){
            while(set.Contains(s[r])){
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            result = Math.Max(result, r - l + 1);
        }
        return result;
    }
}

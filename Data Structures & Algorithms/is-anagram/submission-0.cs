public class Solution {
    public bool IsAnagram(string s, string t) {
        //if(s.Length == 0 && t.Length == 0) return true;
        //if(s.Length == 0 || t.Length == 0) return false;
        if(new string(s.OrderBy(c => c).ToArray()) == new string(t.OrderBy(c => c).ToArray()) )
            return true;
        return false;
    }
}

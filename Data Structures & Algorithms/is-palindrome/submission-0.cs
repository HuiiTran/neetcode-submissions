public class Solution {
    public bool IsPalindrome(string s) {
        string tempS = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
        int l = 0;
        int r = tempS.Length - 1;
        bool result = true;
        while(r >= l){
            if(tempS[l] != tempS[r])
            {
                result = false;
                break;
            }
            r--;
            l++;
        }
        return result;
    }
}

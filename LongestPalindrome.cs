// Solution to LongestPalindrome problem on LeetCode
// Time Complexity:  O(N)?
// Space Complexity: O(N)

public class Solution {

    public string seekPAroundCenter(string s, int start, int end) {

        while ((start > 0) && (end < s.Length - 1)) {
            start--;
            end++;
            if (s[start] != s[end]) {
                return s.Substring(start + 1, end - start - 1);
            }
        }

        return s.Substring(start, end - start + 1);

    }

    public string LongestPalindrome(string s) {

        if ((s == "") || (s.Length == 1)) return s;
        
        string longestP = s[0].ToString();

        if (s[1] == s[0]) {
            longestP = s.Substring(0, 2);
        }

        for (int i = 2; i < s.Length; i++)
        {
            string p = "";
            if (s[i] == s[i-1]) {
                p = seekPAroundCenter(s, i-1, i);
                longestP = (longestP.Length > p.Length) ? longestP : p;
            } 
            if (s[i] == s[i-2]) {
                p = seekPAroundCenter(s, i-2, i);
                longestP = (longestP.Length > p.Length) ? longestP : p;
            }
        }

        return longestP;
    }
}
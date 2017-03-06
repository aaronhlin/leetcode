// Solution to Longest Substring Without Repeating Characters problem on LeetCode
// Time Complexity:  O(N)
// Space Complexity: O(N)

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int start = 0;
        int length = 0;
        var charAndIndex = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++) {
            if (charAndIndex.ContainsKey(s[end])) {
                if (charAndIndex[s[end]] < start) {
                    charAndIndex[s[end]] = end;
                } else {
                    length = Math.Max(length, end - start);
                    start = charAndIndex[s[end]] + 1;
                    charAndIndex[s[end]] = end;
                }
            } else {
                charAndIndex.Add(s[end], end);
            }
        }

        length = Math.Max(length, s.Length - start);
        return length;
    }
}
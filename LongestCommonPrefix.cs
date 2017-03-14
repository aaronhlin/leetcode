// Solution to Longest Common Prefix problem on LeetCode
// Time Complexity: O(S) where S is the sum of all characters in the array
// Space Complexity: O(1)

public class Solution {
    public string StrCompare(string str1, string str2) {
        var commonPrefix = "";
        var shortestLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < shortestLength; i++) {
            if (str1[i] == str2[i]) {
                commonPrefix += str1[i];
            } else {
                break;
            }
        }

        return commonPrefix;
    }

    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";

        var longestPrefix = strs[0];
        for (int i = 0; i < strs.Length; i++) {
            longestPrefix = StrCompare(longestPrefix, strs[i]);
        }

        return longestPrefix;
    }
}
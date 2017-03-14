// Solution to MaxArea problem on LeetCode
// Time Complexity:  O(N)
// Space Complexity: O(1)

public class Solution {
    public int MaxArea(int[] height) {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right) {
            maxArea = Math.Max(maxArea, (right - left) * Math.Min(height[left], height[right]));

            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}
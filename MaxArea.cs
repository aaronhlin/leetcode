// Solution to MaxArea problem on LeetCode
// Time Complexity:  O(NlogN)
// Space Complexity: O(N)

public class Solution {
    public int MaxArea(int[] height) {
        var sortedHeight = height.Select((value, index) => new {Value = value, Index = index})
                                 .OrderByDescending(x => x.Value)
                                 .ToArray();
        
        var maxArea       = 0;
        var smallestIndex = sortedHeight[0].Index;
        var largestIndex  = sortedHeight[0].Index;

        for (int i = 1; i < sortedHeight.Length; i++) {
            var index = sortedHeight[i].Index;

            smallestIndex = Math.Min(smallestIndex, index);
            largestIndex  = Math.Max(largestIndex, index);

            var maxWidth = Math.Max(index - smallestIndex, largestIndex - index);
            maxArea = Math.Max(maxArea, maxWidth * sortedHeight[i].Value);
        }

        return maxArea;
    }
}
// Solution to TwoSum problem on LeetCode
// Time Complexity:  O(NlogN)
// Space Complexity: O(N)

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var sortedNums = nums.Select((value, index) => new { Value = value, Index = index })
                             .OrderBy(x => x.Value)
                             .ToArray();

        int i = 0;
        int j = nums.Length - 1;

        while (i != j)
        {
            int sum = sortedNums[i].Value + sortedNums[j].Value;

            if (sum > target)
            {
                j--;
            }
            else if (sum < target)
            {
                i++;
            }
            else
            {
                return new int[2] {sortedNums[i].Index, sortedNums[j].Index};
            }
        }

        return new int[2] {-1,-1};
    }
}
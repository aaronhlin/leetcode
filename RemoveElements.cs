// Solution to Remove Element problem on LeetCode
// Time Complexity: O(N)
// Space Complexity: O(1)

public class Solution {
    public void swap(int[] array, int i, int j) {
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }

    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) {
            return 0;
        }

        int i = 0;
        int j = 0;

        while (j < nums.Length) {
            if (nums[i] != val) {
                i++;
            } else if (nums[j] != val) {
                swap(nums, i, j);
                i++;
            }

            j++;
        }

        return i;
    }
}
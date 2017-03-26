// Solution to Remove Duplicates from Sorted Array problem on LeetCode
// Time Complexity: O(N) 
// Space Complexity: O(1)

public class Solution {
    public void swap(int[] array, int i, int j) {
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }

    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }

        int i = 0;
        int j = 0;

        while (j < nums.Length) {
            if (nums[j] > nums[i]) {
                i++;
                swap(nums, i, j);
            }
            j++;
        }

        return i + 1;
    }
}
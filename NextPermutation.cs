// Solution to Next Permutation problem on LeetCode
// Time Complexity: O(N)
// Space Complexity: O(1)

public class Solution {
    public void swap(int[] array, int i, int j) {
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }

    public void ReverseArray(int[] array, int start, int end) {
        int middle = (int)Math.Ceiling((double)(end-start)/2);
        for (int i = 0; i < middle; i++) {
            swap(array, start + i, end - i);
        }
    }

    public void NextPermutation(int[] nums) {
        int i = nums.Length - 1;

        while (i > 0) {
            if (nums[i] > nums[i-1]) {
                break;
            } else {
                i--;
            }
        }

        //Array is already at greatest permutation
        if (i == 0) {
            ReverseArray(nums, 0, nums.Length - 1);
            return;
        }

        int j = i;
        while (j < nums.Length) {
            if (nums[j] <= nums[i - 1]) {
                break;
            } else {
                j++;
            }
        }

        swap(nums, i - 1, j - 1);
        ReverseArray(nums, i, nums.Length - 1);
    }
}
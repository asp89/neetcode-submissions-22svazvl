public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        // left = 0, right = 5
        // left = 0, right = 1
        // left = 1, right = 1
        while (left <= right) {
            // 2, 0, 1
            int mid = left + (right - left) / 2;  
            Console.WriteLine($"mid = {mid}, left={left}, right={right}");

            // nums[2] = 6
            // nums[0] = 3
            // nums[1] = 5
            if (nums[mid] == target)
                return mid;

            // nums[0] = 3, nums[2] = 6
            // nums[0] = 3, nums[0] = 3, 
            // 
            if (nums[left] <= nums[mid]) {
                if (target >= nums[left] && target < nums[mid])
                    right = mid - 1; // 0
                else
                    left = mid + 1; // 1
            } else {
                if (target > nums[mid] && target <= nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        return -1;
    }
}

public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();
        int n = nums.Length;

        // Iterate through each element to be the first number in the triplet.
        for (int i = 0; i < n - 2; i++) {
            // Skip duplicate values for the first element to avoid duplicate triplets.
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            int left = i + 1; // Pointer for the second element.
            int right = n - 1; // Pointer for the third element.

            // Use the two-pointer approach for the remaining elements.
            while (left < right) {
                int total = nums[i] + nums[left] + nums[right];

                if (total == 0) {
                    // Found a triplet that sums to zero.
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicate values for the second and third elements.
                    while (left < right && nums[left] == nums[left + 1]) {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right - 1]) {
                        right--;
                    }
                    
                    // Move both pointers inward to find the next unique pair.
                    left++;
                    right--;
                } else if (total < 0) {
                    // Sum is too small, move the left pointer to a larger value.
                    left++;
                } else {
                    // Sum is too large, move the right pointer to a smaller value.
                    right--;
                }
            }
        }
        return result;
    }
}

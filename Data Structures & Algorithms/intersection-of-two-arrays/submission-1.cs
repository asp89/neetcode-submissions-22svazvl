public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> result = new();

        Array.Sort(nums2);

        foreach (int n1 in nums1) {
            if (BinarySearch(nums2, n1))
                result.Add(n1);
        }

        return result.ToArray();
    }

    private bool BinarySearch(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return true;
            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }
}
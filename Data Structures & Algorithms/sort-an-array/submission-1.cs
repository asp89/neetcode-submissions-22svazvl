public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;

        for (int i = (n / 2) - 1; i >= 0; i--) Heapify(nums, n, i);

        for (int i = n - 1; i > 0; i--) {
            Swap(nums, 0, i);
            Heapify(nums, i, 0);
        }

        return nums;
    }

    private void Heapify(int[] nums, int size, int root) {
        while (true) {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < size && nums[left] > nums[largest])
                largest = left;

            if (right < size && nums[right] > nums[largest])
                largest = right;

            if (largest == root)
                break;

            // These two lines were missing
            Swap(nums, root, largest);
            root = largest;
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

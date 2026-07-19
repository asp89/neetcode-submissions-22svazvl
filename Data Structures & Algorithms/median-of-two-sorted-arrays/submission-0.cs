public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        int totalLength = m + n;
        int[] result = new int[totalLength];

        int i = 0, j = 0, k = 0;
        while (i < m && j < n) {
            if (nums1[i] <= nums2[j]) {
                result[k] = nums1[i];
                i++;
            } else {
                result[k] = nums2[j];
                j++;
            }
            k++;
        }

        while (i < m) {
            result[k] = nums1[i];
            i++;
            k++;
        }

        while (j < n) {
            result[k] = nums2[j];
            j++;
            k++;
        }

        if (totalLength % 2 != 0)
            return result[totalLength / 2];
        else {
            int mid = result[totalLength / 2];
            int mid2 = result[(totalLength / 2) - 1];
            return (mid + mid2) / 2.0;
        }
    }
}

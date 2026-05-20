public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] res = new int[m + n];
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < m && j < n) {
            if (nums1[i] <= nums2[j]) {
                res[k] = nums1[i];
                i++;
            } else {
                res[k] = nums2[j];
                j++;
            }
            k++;
        }

        while (i < m) {
            res[k] = nums1[i];
            i++;
            k++;
        }

        while (j < n) {
            res[k] = nums2[j];
            j++;
            k++;
        }

        i = 0;
        while (i < m + n) {
            nums1[i] = res[i];
            i++;
        }

        nums1 = res;
    }
}

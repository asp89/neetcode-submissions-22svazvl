public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for (int i = 0; i < n; i++) {
            nums1[m + i] = nums2[i];
        }

        Console.WriteLine(string.Join(",", nums1));
        for (int i = 0; i < nums1.Length; i++) {
            for (int j = 0; j < nums1.Length - 1; j++) {
                if (nums1[j] > nums1[j + 1])
                    (nums1[j], nums1[j + 1]) = (nums1[j + 1], nums1[j]);
            }
        }
    }
}
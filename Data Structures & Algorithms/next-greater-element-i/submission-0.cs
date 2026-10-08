public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++) {
            int currentNumber = nums1[i];
            result[i] = -1;

            int j = 0;
            while (j < nums2.Length && nums2[j] != currentNumber)
                j++;
            
            j++;

            while (j < nums2.Length) {
                if (nums2[j] > currentNumber) {
                    result[i] = nums2[j];
                    break;
                }

                j++;
            }
        }

        return result;
    }
}
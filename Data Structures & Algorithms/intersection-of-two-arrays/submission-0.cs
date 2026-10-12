public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> result = new();

        foreach (int n1 in nums1) {
            foreach (int n2 in nums2) {
                if (n1 == n2)
                    result.Add(n1);
            }
        }

        return result.ToArray();
    }
}
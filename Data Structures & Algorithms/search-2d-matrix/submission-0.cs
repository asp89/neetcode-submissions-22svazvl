public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach (int[] m in matrix) {
            for (int i = 0; i < m.Length; i++) {
                if (m[i] == target)
                    return true;
            }
        }

        return false;
    }
}

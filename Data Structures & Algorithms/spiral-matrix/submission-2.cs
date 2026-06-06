public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        int n = matrix.Length, m = matrix[0].Length;
        int left = 0, right = m - 1;
        int top = 0, bottom = n - 1;

        var answer = new List<int>();

        while (left <= right && top <= bottom) {
            // left -> right
            for (int j = left; j <= right; j++) answer.Add(matrix[top][j]);

            top++;

            // top -> bottom
            for (int i = top; i <= bottom; i++) answer.Add(matrix[i][right]);

            right--;

            // right -> left
            if (top <= bottom) {
                for (int j = right; j >= left; j--) answer.Add(matrix[bottom][j]);
                bottom--;
            }

            // bottom -> top
            if (left <= right) {
                for (int i = bottom; i >= top; i--) answer.Add(matrix[i][left]);
                left++;
            }
        }
        return answer;
    }
}

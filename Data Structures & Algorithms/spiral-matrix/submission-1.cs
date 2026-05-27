public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        int n = matrix.Length, m = matrix[0].Length;
        int left = 0, right = m - 1;
        int top = 0, bottom = n - 1;

        var answer = new List<int>();

        while (left <= right && top <= bottom) 
        
        {
            // left to right
            int i = top, j = left;
            while (j <= right) {
                answer.Add(matrix[i][j]);
                j++;
            }
            top++;

            // top-right to bottom
            i = top;
            j = right;
            while (i <= bottom){
                answer.Add(matrix[i][j]);
                i++;
            }
            right--;

            // move left
            if (top <= bottom) {
                i = bottom;
                j = right;
                while (j >= left) {
                    answer.Add(matrix[i][j]);
                    j--;
                }
                bottom--;
            }

            // move up
            if (left <= right) {
                i = bottom;
                j = left;
                while (i >= top) {
                    answer.Add(matrix[i][j]);
                    i--;
                }
                left++;
            }
        }
        return answer;
    }
}
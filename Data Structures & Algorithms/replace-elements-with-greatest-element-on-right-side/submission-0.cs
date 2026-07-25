public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxVal = -1;

        for (int i = arr.Length - 1; i >= 0; i--) {
            int temp = arr[i];
            arr[i] = maxVal;
            if (maxVal < temp)
                maxVal = temp;
        }
        return arr;
    }
}
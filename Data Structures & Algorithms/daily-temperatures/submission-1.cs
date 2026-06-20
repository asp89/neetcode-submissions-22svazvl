public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int length = temperatures.Length;
        int[] result = new int[length];
        var stack = new Stack<int>();

        for (int i = 0; i < length; i++) {
            int currentTemperature = temperatures[i];

            while (stack.Count > 0 && currentTemperature > temperatures[stack.Peek()]) {
                int prevIndex = stack.Pop();
                result[prevIndex] = i - prevIndex;
            }

            stack.Push(i);
        }

        return result;
    }
}

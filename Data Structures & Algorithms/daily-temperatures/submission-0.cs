public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int length = temperatures.Length;
        int[] result = new int[length];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < length; i++) {
            int currentTemp = temperatures[i];
            while (stack.Count > 0 && currentTemp > temperatures[stack.Peek()]) {
                int prevIndex = stack.Pop();
                result[prevIndex] = i - prevIndex; 
            }
            stack.Push(i);
        }

        return result;
    }
}

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new();

        foreach (int ast in asteroids) {
            int curr = ast;
            bool exploded = false;

            while (stack.Count > 0 && curr < 0 && stack.Peek() > 0) {
                int topVal = stack.Peek();

                if (Math.Abs(curr) > Math.Abs(topVal))
                    stack.Pop();
                else if (Math.Abs(curr) == Math.Abs(topVal)) {
                    stack.Pop();
                    exploded = true;
                    break;
                } else {
                    exploded = true;
                    break;
                }
            }

            if (!exploded)
                stack.Push(curr);
        }

        int[] result = stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}
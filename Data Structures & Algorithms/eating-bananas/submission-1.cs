public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = piles.Max();
        int result = max;
        int low = 1;

        while (low <= max) {
            int mid = low + (max - low) / 2;

            long time = 0;
            foreach (int pile in piles) {
                time = time + (pile + mid - 1) / mid;
            }

            if (time > h)
                low = mid + 1;
            else {
                result = mid;
                max = mid - 1;
            }
        }

        return result;
    }
}

public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = piles.Max();

        for (int i = 1; i <= max; i++) {
            long time = 0;

            for (int j = 0; j < piles.Length; j++) {
                time = time + (piles[j] + i - 1) / i;
            }

            if (time <= h)
                return i;
        }

        return max;
    }
}

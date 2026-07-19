public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new();
        while (n != 1 && !seen.Contains(n)) {
            seen.Add(n);
            n = SumOfSquaresOfDigits(n);
        }

        return n == 1;
    }

    private int SumOfSquaresOfDigits(int num) {
        int sum = 0;

        while (num > 0) {
            int digit = num % 10;
            sum = sum + (digit * digit);
            num = num / 10;
        }

        return sum;
    }
}

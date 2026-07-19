public class Solution {
    public double MyPow(double x, int n) {
        if (n < 0)
            return 1.0 / FastPow(x, -n);
        
        return FastPow(x, n);
    }

    private double FastPow(double x, long n) {
        if (n == 0) return 1.0;

        double h = FastPow(x, n / 2);

        if (n % 2 == 0)
            return h * h;
        else
            return h * h * x;
    }
}

public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        if (n <= 1)
            return n;

        var cars = new(int Position, int Speed)[n];
        for (int i = 0; i < n; i++) cars[i] = (position[i], speed[i]);

        Array.Sort(cars, (a, b) => b.Position.CompareTo(a.Position));

        int fleetCount = 0;
        double maxTime = 0.0;

        for (int i = 0; i < n; i++) {
            double timeToTarget = (double)(target - cars[i].Position) / cars[i].Speed;

            if (timeToTarget > maxTime) {
                fleetCount++;
                maxTime = timeToTarget;
            }
        }

        return fleetCount;
    }
}

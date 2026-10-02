public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;

        foreach (string citizen in details) {
            string age = citizen[^4..^2];
            if (int.TryParse(age, out int result))
            {
                if (result >= 60)
                    count++;
            }
        }

        return count;
    }
}
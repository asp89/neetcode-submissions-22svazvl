public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder result = new();

        while (columnNumber > 0) {
            columnNumber--;

            int remainder = columnNumber % 26;

            result.Insert(0, (char)('A' + remainder));

            columnNumber /= 26;
        }

        return result.ToString();
    }
}
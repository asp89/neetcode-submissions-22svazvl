public class Solution {
    public bool WordPattern(string pattern, string s) {
        var strs = s.Split(" ");
        if (strs.Length != pattern.Length)
            return false;

        Dictionary<char, string> map = new();
        HashSet<string> assigned = new();

        for (int i = 0; i < strs.Length; i++) {
            char c = pattern[i];
            string currWord = strs[i];

            if (map.TryGetValue(c, out string existingWord)) {
                if (existingWord != currWord)
                    return false;
            } else {
                if (assigned.Contains(currWord))
                    return false;

                map[c] = currWord;
                assigned.Add(currWord);
            }
        }

        return true;
    }
}
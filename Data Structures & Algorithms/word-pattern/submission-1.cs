public class Solution {
    public bool WordPattern(string pattern, string s) {
        var strs = s.Split(" ");
        if (strs.Length != pattern.Length)
            return false;

        Dictionary<char, string> map = new();
        HashSet<string> assigned = new();

        for (int i = 0; i < strs.Length; i++) {
            char c = pattern[i];       // a
            string currStr = strs[i];  // dog

            if (map.ContainsKey(c) && (map[c] != currStr))
                return false;
            else {
                var charKVP = map.FirstOrDefault(x => x.Value == currStr);
                Console.WriteLine(
                    $"{c}, {currStr}, {charKVP.Key}, {char.IsWhiteSpace(charKVP.Key)}, {charKVP.Key == '\0'}, {i}");
                if (charKVP.Key != '\0' && charKVP.Key != c)
                    return false;
                // if (!char.IsWhiteSpace(key) && charKey != c)
                //     return false;

                map[c] = currStr;       // {a: dog, b: cat}
                assigned.Add(currStr);  // [dog, cat]
            }
        }

        return true;
    }
}
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!result.ContainsKey(key)) {
                result[key] = new List<string>();
            }
            result[key].Add(str);
        }

        return result.Values.ToList();
    }
}

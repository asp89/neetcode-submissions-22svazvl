public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int count = 0;

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            while (!strs[i].StartsWith(prefix)) {
                prefix = prefix[..^ 1];

                if (prefix == "")
                    return "";
            }
        }
        return prefix;
    }
}
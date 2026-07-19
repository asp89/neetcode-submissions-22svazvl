public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
            return false;
        
        Dictionary<char, char> map = new();
        HashSet<char> assigned = new();

        for (int i = 0; i < s.Length; i++) {
            char sChar = s[i];
            char tChar = t[i];

            if (map.ContainsKey(sChar)) {
                if (map[sChar] != tChar)
                    return false;
            } else {
                if (assigned.Contains(tChar)) 
                    return false;
                
                map[sChar] = tChar;
                assigned.Add(tChar);
            }
        }

        return true;
    }
}
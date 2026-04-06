public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key))
            {
                map[key] = new();
            }
            
            map[key].Add(str);
        }

        return map.Values.ToList();   
    }
}

public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> arr = new();
        foreach (int num in nums)
        {
            if (!arr.Add(num))
                return true;
        }

        return false;
    }
}
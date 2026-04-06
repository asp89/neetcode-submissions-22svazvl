class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        count = {}
        res = 0
        l = 0
        max_f = 0

        for r in range(len(s)):
            # Increment frequency of the current character
            count[s[r]] = count.get(s[r], 0) + 1

            # Update the maxium frequency found in the current window
            max_f = max(max_f, count[s[r]])

            # Check if the current window is valid
            # Window Size - Frequency of the frequent char must be <= k
            while (r - l + 1) - max_f > k:
                count[s[l]] -= 1
                l += 1
            
            # Update result with the maxium valid window size found so far
            res = max(res, r - l + 1)
        return res


        
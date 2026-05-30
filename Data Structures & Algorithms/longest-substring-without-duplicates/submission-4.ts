class Solution {
    /**
     * @param {string} s
     * @return {number}
     */
    lengthOfLongestSubstring(s: string): number {
        let i: number = 0;
        let j: number = 0;
        let result: number = 0;
        const set = new Set();

        while (j < s.length) {
            if (set.has(s[j])) {
                set.delete(s[i]);
                i++;
            } else {
                result = Math.max(result, j - i + 1);
                set.add(s[j]);
                j++;
            }
        }

        return result;
    }
}

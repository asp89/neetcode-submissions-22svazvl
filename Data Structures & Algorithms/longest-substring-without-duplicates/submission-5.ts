class Solution {
    /**
     * @param {string} s
     * @return {number}
     */
    lengthOfLongestSubstring(s: string): number {
        let i = 0
        let j = 0
        let result = 0
        const set = new Set()

        while (j < s.length) {
            if (set.has(s[j])) {
                set.delete(s[i])
                i++
            } else {
                result = Math.max(result, j - i + 1)
                set.add(s[j])
                j++
            }
        }

        return result
    }
}

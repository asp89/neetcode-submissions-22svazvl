class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s: string, t: string): boolean {
        if (s.length !== t.length) return false

        const frequency: number[] = new Array(26).fill(0)

        for (const ch of s)
            frequency[ch.charCodeAt(0) - 'a'.charCodeAt(0)]++
        
        for (const ch of t)
            frequency[ch.charCodeAt(0) - 'a'.charCodeAt(0)]--

        for (const freq of frequency) {
            if (freq != 0) return false
        }
        return true
    }
}
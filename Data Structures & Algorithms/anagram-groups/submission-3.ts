class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs: string[]): string[][] {
        const result = new Map<string, string[]>();

        for (const str of strs) {
            const key = [...str].sort().join("");
            result[key] ??= [];
            result[key].push(str);
        }

        return Object.values(result);
    }
}

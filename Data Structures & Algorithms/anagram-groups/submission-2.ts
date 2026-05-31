class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs: string[]): string[][] {
        const result = new Map<string, string[]>();

        strs.forEach((str) => {
            const key = [...str].sort().join("");
            result[key] ??= [];
            result[key].push(str);
        });

        return Object.values(result);
    }
}

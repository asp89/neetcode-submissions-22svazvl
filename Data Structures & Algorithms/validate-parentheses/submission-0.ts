class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isValid(s: string): boolean {
        const map: Record<string, string> = {
            ")": "(",
            "}": "{",
            "]": "[",
        };

        const stack: string[] = [];
        const values = Object.values(map)

        for (const ch of s) {
            if (values.includes(ch)) stack.push(ch);
            else {
                if (stack.pop() !== map[ch]) {
                    return false;
                }
            }
        }

        return stack.length === 0;
    }
}

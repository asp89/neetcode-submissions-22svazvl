class Solution {
    /**
     * @param {character[]} chars
     * @return {number}
     */
    compress(chars: string[]): number {
        let write = 0;
        let read = 0;

        while (read < chars.length) {
            const currentChar = chars[read];
            let count = 0;

            while (read < chars.length && chars[read] === currentChar) {
                read++;
                count++;
            }

            chars[write++] = currentChar;

            if (count > 1) {
                for (const digit of count.toString()) {
                    chars[write++] = digit;
                }
            }
        }

        return write;
    }
}

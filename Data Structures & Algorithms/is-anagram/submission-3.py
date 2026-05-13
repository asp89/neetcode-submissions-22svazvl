class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        count = {}

        for ch in s:
            count[ch] = count.get(ch, 0) + 1
            print(ch, count[ch])

        for ch in t:
            count[ch] = count.get(ch, 0) - 1
            print(ch, count[ch])

        for val in count.values():
            print(val)
            if val != 0:
                return False
        return True

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        count = {}

        print("Print characters from S")
        for ch in s:
            count[ch] = count.get(ch, 0) + 1
            print(ch, count[ch])
        
        print("Print characters from T")
        for ch in t:
            count[ch] = count.get(ch, 0) - 1
            print(ch, count[ch])

        print(count)
        print("Print Count Values")
        for val in count.values():
            print(val)
            if val != 0:
                return False

        return True
        
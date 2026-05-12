class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        for i in range(0, len(flowerbed)):
            if flowerbed[i] == 0:
                emptyLeft = i == 0 or flowerbed[i - 1] == 0
                emptyRight = i == len(flowerbed) - 1 or flowerbed[i + 1] == 0
                if emptyLeft and emptyRight:
                    flowerbed[i] = 1
                    n -= 1
            if n <= 0:
                return True
        return n <= 0

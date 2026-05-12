class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        mapElements = {}
        
        for i in range(len(nums)):
            currentNumber = nums[i]
            needed = target - currentNumber

            if needed in mapElements:
                return [mapElements[needed], i]

            mapElements[currentNumber] = i

        return []
        
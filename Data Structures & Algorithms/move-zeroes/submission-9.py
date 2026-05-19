class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        index = 0

        for current_num in nums:
            if current_num is not 0:
                nums[index] = current_num
                index += 1
        
        while index < len(nums):
            nums[index] = 0
            index += 1
# [0, 0, 1, 2, 0, 5]
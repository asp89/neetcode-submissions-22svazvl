class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        current_sum = nums[0]
        max_sum = nums[0]

        for i in range(1, len(nums)):
            num = nums[i]
            if num > current_sum + num:
                current_sum = num
            else:
                current_sum = current_sum + num
            if max_sum < current_sum:
                max_sum = current_sum
        return max_sum 
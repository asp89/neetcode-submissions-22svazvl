class Solution:
    def maxArea(self, heights: List[int]) -> int:
        max_area = 0
        n = len(heights)

        for i in range(n):
            for j in range(i + 1, n):
                min_val = min(heights[i], heights[j])
                current_area = (j - i) * min_val
                max_area = max(current_area, max_area)
        return max_area
        
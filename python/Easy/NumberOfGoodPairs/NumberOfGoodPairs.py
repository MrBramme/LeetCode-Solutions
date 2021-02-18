# https://leetcode.com/problems/number-of-good-pairs/
from typing import List

def numIdenticalPairs(self, nums: List[int]) -> int:
    result = 0
    for startIndex, num1 in enumerate(nums, start=1):
        for num2 in nums[startIndex:]:
            if num1 == num2:
                result = result + 1
    return result
        
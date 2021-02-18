# https://leetcode.com/problems/running-sum-of-1d-array/
from typing import List

def runningSum(self, nums: List[int]) -> List[int]:
    result = []
    currentSum = 0
    for num in nums:
        currentSum += num 
        result.append(currentSum)
    return result

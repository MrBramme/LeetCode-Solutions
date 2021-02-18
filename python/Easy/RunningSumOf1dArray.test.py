import unittest
from RunningSumOf1dArray import runningSum


class TestRunningSumOf1dArray(unittest.TestCase):

    def test_1(self):
        result = runningSum(self, [1, 2, 3, 4])
        self.assertEqual(result, [1, 3, 6, 10], "Should be expected")

    def test_2(self):
        result = runningSum(self, [1,1, 1, 1, 1])
        self.assertEqual(result, [1, 2, 3, 4, 5], "Should be expected")

    def test_3(self):
        result = runningSum(self, [3, 1, 2, 10, 1])
        self.assertEqual(result, [3, 4, 6, 16, 17], "Should be expected")

if __name__ == '__main__':
    unittest.main()
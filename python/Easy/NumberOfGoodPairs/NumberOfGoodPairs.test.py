import unittest
from NumberOfGoodPairs import numIdenticalPairs


class TestNumberOfGoodPairs(unittest.TestCase):

    def test_1(self):
        result = numIdenticalPairs(self, [1,2,3,1,1,3])
        self.assertEqual(result, 4, "There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.")

    def test_2(self):
        result = numIdenticalPairs(self, [1,1,1,1])
        self.assertEqual(result, 6, "Each pair in the array are good.")

    def test_3(self):
        result = numIdenticalPairs(self, [1,2,3])
        self.assertEqual(result, 0, "Should be expected")

if __name__ == '__main__':
    unittest.main()
﻿using System.Linq;

namespace LeetCode.Solutions.March2021Dailies
{
    // https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3663/
    public class MyHashMap
    {
        private readonly int[] _values;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            _values = Enumerable.Range(0, 1000000).Select(i => -1).ToArray();
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            _values[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return _values[key];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            _values[key] = -1;
        }
    }
}
using System;

namespace LeetCode.Solutions.Medium
{
    // https://leetcode.com/problems/reverse-integer/
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var charArray = x.ToString().Replace("-", "").ToCharArray();
            Array.Reverse(charArray, 0, charArray.Length);
            var res = 0;
            int.TryParse(new string(charArray), out res);
            return x >= 0 ? res : res * -1;
        }
    }
}

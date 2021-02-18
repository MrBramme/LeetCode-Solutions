using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/buddy-strings/
    public class BuddyStrings
    {
        public bool Run(string a, string b)
        {
            if (IsEitherInputEmpty(a, b)) return false;
            if (a.Length == 1 || b.Length == 1) return false;
            if (IsInputIdenticalAndMadeOutOfASingleCharacter(a, b)) return true;
            if (!a.Length.Equals(b.Length)) return false;

            var mismatchIndices = new List<int>();
            for (var i = 0; i < a.Length; i++)
            {
                if (!a[i].Equals(b[i]))
                {
                    mismatchIndices.Add(i);
                }

                if (mismatchIndices.Count > 2)
                {
                    break;
                }
            }

            var result = false;
            var listHasOnly2Mismatches = mismatchIndices.Count == 2;
            if (listHasOnly2Mismatches)
            {
                if (a[mismatchIndices[0]].Equals(b[mismatchIndices[1]]) &&
                    a[mismatchIndices[1]].Equals(b[mismatchIndices[0]]))
                {
                    result = true;
                }
            }

            if (!mismatchIndices.Any())
            {
                if (a.Distinct().Count() < a.Length)
                {
                    result = true;
                }
            }
            return result;
        }

        private static bool IsInputIdenticalAndMadeOutOfASingleCharacter(string a, string b)
        {
            return a.Equals(b) && a.Distinct().Count() == 1;
        }

        private static bool IsEitherInputEmpty(string a, string b)
        {
            return string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b);
        }
    }
}
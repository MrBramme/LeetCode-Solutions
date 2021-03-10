using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.March2021Dailies
{
    // https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3667/
    public class Day10IntegerToRoman
    {
        private static readonly Dictionary<string, int> _romanValues = new Dictionary<string, int>
        {
            {"M", 1000},
            {"D", 500},
            {"C", 100},
            {"L", 50},
            {"X", 10},
            {"V", 5},
            {"I", 1},
        };

        private static readonly Dictionary<string, string> _romanPrefixes = new Dictionary<string, string>
        {
            {"M", "C"},
            {"D", "C"},
            {"C", "X"},
            {"L", "X"},
            {"X", "I"},
            {"V", "I"},
            {"I", "I"},
        };

        public string IntToRoman(int num)
        {
            var sb = new StringBuilder();

            num = ProcessRoman(num, sb, "M");
            num = ProcessRoman(num, sb, "D");
            num = ProcessRoman(num, sb, "C");
            num = ProcessRoman(num, sb, "L");
            num = ProcessRoman(num, sb, "X");
            num = ProcessRoman(num, sb, "V");
            num = ProcessRoman(num, sb, "I");

            return sb.ToString();
        }

        private static int ProcessRoman(int num, StringBuilder sb, string roman)
        {
            while (num >= _romanValues[roman])
            {
                sb.Append(roman);
                num -= _romanValues[roman];
            }

            if (num > 0 && num >= _romanValues[roman] - _romanValues[_romanPrefixes[roman]])
            {
                sb.Append(_romanPrefixes[roman]);
                sb.Append(roman);
                num -= _romanValues[roman] - _romanValues[_romanPrefixes[roman]];
            }

            return num;
        }
    }
}
namespace LeetCode.Solutions.Medium
{
    // https://leetcode.com/problems/string-to-integer-atoi/
    public class StringToIntAtoi
    {
        // Procedural approach alert!!! :D
        public int MyAtoi(string s)
        {
            var charArray = s.Trim().ToCharArray();
            if (charArray.Length == 0)
            {
                return 0;
            }

            var isNeg = charArray[0] == '-';
            var startPos = isNeg || charArray[0] == '+' ? 1 : 0;
            var currentPos = startPos;

            var isDigit = true;
            while (currentPos < charArray.Length && isDigit)
            {
                isDigit = char.IsDigit(charArray[currentPos]);
                if (isDigit)
                {
                    currentPos++;
                }
            }

            if (startPos == currentPos)
            {
                return 0;
            }

            var numStr = string.Format("{0}{1}", isNeg ? "-" : "+", new string(charArray, startPos, currentPos - startPos));
            if (!int.TryParse(numStr, out var res))
            {
                res = isNeg ? int.MinValue : int.MaxValue;
            }

            return res;
        }
    }
}

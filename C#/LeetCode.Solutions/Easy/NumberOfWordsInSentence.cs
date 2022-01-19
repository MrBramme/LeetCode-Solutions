using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
    public class NumberOfWordsInSentence
    {
        public int MostWordsFound(string[] sentences)
        {
            return sentences.Select(x => x.ToCharArray().Count(c => c.Equals(' ')) + 1).Max();
        }
    }
}
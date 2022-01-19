using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/number-of-valid-words-in-a-sentence/
    public class NumberOfValidWordsInSentence
    {
        Regex invalidCharRegex = new Regex("[^a-z.,!-]", RegexOptions.Compiled);
        Regex hyphenWrappedCheck = new Regex("[a-z]-[a-z]", RegexOptions.Compiled);
        Regex punctuationEndingCheck = new Regex("[!.,]$", RegexOptions.Compiled);

        public int CountValidWords(string sentence)
        {
            return sentence.Split(' ')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Where(x => OnlycontainsValidCharacters(x))
                .Where(x => HyphenCheck(x))
                .Where(x => PunctuationCheck(x))
                .Count();
        }

        public bool OnlycontainsValidCharacters(string token)
        {
            return !invalidCharRegex.Match(token).Success;
        }

        public bool HyphenCheck(string token)
        {
            var hyphenCount = token.Count(t => t == '-');
            if (hyphenCount == 0) return true;
            if (hyphenCount == 1) return hyphenWrappedCheck.Match(token).Success;
            return false;
        }

        public bool PunctuationCheck(string token)
        {
            var hyphenCount = token.Count(t => t == '!' || t == '.' || t == ',');
            if (hyphenCount == 0) return true;
            if (hyphenCount == 1) return punctuationEndingCheck.Match(token).Success;
            return false;
        }
    }
}
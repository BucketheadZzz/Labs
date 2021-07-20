using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Labs.Lab5
{
    public static class LabTasks
    {
        public static bool IsLoginCorrect(string login)
        {
            var pattern = @"\b(?![1-9])\S{2,10}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(login);

            return matches.Count > 0;
        }

        public static string RemoveSomeWords(string message, char startSymbol)
        {
            var pattern = $@"\b{startSymbol}\w*\b";
            Regex regex = new Regex(pattern);
            string resultString = regex.Replace(message, String.Empty);

            return resultString;
        }

        public static string[] GetWordsUpToLength(string message, int maxWordLength)
        {
            var pattern = $@"\b\S{{1,{maxWordLength}}}\b\s*";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(message);

            var resultList = new List<string>();
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    resultList.Add(match.Value);
            }

            return resultList.ToArray();
        }

        public static string GetLongestWords(string message, int numberLongestWordsToReturn = 1)
        {
            // without regex
            // message.Split(' ').Select(word => word.Trim()).OrderByDescending(word => word.Length).First();

            var longestWords = new List<string>();

            var regex = new Regex(@"(\w+)\s");
            var match = regex.Match(message);
            while (numberLongestWordsToReturn > 0)
            {
                var currentLargestString = "";
                if (match.Length > 0)
                {
                    while (match.Success)
                    {
                        var matchedValue = match.Groups[1].Value;
                        if (!longestWords.Contains(matchedValue) && matchedValue.Length > currentLargestString.Length)
                        {
                            currentLargestString = matchedValue;
                        }

                        match = match.NextMatch();
                    }
                }

                longestWords.Add(currentLargestString);

                numberLongestWordsToReturn--;
            }

            var resultString = new StringBuilder(string.Join(" ", longestWords));
            return resultString.ToString();
        }

        public static bool IsStringValueShuffled(string originalValue, string shuffledString)
        {
            return originalValue.Length == shuffledString.Length && new string(originalValue.OrderBy(c => c).ToArray()) == new string(shuffledString.OrderBy(c => c).ToArray());
        }
    }
}

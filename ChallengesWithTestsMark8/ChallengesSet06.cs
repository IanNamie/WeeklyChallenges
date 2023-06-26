using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
			if (words == null)
			{
				return false;
			}

			if (ignoreCase)
			{
				return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
			}
			else
			{
				return words.Contains(word);
			}
		}

        public bool IsPrimeNumber(int num)
        {
			if (num <= 1)
				return false;

			int sqrt = (int)Math.Sqrt(num);

			for (int i = 2; i <= sqrt; i++)
			{
				if (num % i == 0)
					return false;
			}

			return true;
		}

        public int IndexOfLastUniqueLetter(string str)
        {
			if (string.IsNullOrEmpty(str))
			{
				return -1;
			}

			Dictionary<char, int> letterCount = new Dictionary<char, int>();

			for (int i = 0; i < str.Length; i++)
			{
				char currentLetter = str[i];
				if (letterCount.ContainsKey(currentLetter))
				{
					letterCount[currentLetter] = -1; // Mark as non-unique
				}
				else
				{
					letterCount[currentLetter] = i; // Store the index
				}
			}

			int lastUniqueIndex = -1;

			foreach (var pair in letterCount)
			{
				if (pair.Value != -1)
				{
					lastUniqueIndex = Math.Max(lastUniqueIndex, pair.Value);
				}
			}

			return lastUniqueIndex;
		}

        public int MaxConsecutiveCount(int[] numbers)
        {
			if (numbers == null || numbers.Length == 0)
			{
				return 0;
			}

			int maxCount = 0;
			int currentCount = 1;

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] == numbers[i - 1])
				{
					currentCount++;
				}
				else
				{
					maxCount = Math.Max(maxCount, currentCount);
					currentCount = 1;
				}
			}

			return Math.Max(maxCount, currentCount);
		}

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
			if (elements == null || n <= 0)
			{
				return new double[0];
			}

			List<double> result = new List<double>();

			for (int i = n - 1; i < elements.Count; i += n)
			{
				result.Add(elements[i]);
			}

			return result.ToArray();
		}
    }
}

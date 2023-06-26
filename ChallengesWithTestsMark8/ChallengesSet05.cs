using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber;

            if (nextNumber == 0)
            { 
                nextNumber += n;
            }
            
            while (nextNumber % n != 0) 
            {
            nextNumber++;
            }
            if (nextNumber == startNumber) 
            {
                nextNumber += n; 
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {

			foreach (Business business in businesses)
			{
				if (business.TotalRevenue == 0)
				{
					business.Name = "CLOSED";
				}
			}

		}

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }
            for (int i = 1; i < numbers.Length; i++) 
            {
                if (numbers[i] < numbers[i - 1]) 
                {
                    return false;
                }
            }
            return true;
		}

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
			if (numbers == null) { return 0; }

			int sum = 0;
			for (int i = 0; i < numbers.Length - 1; i++)
			{
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
                
			}
			return sum;
		}

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) { return ""; }
            else if (words.Length == 0) { return string.Empty; }
			string[] trimmedWords = words.Select(word => word.Trim()).Where(word => !string.IsNullOrWhiteSpace(word)).ToArray();
			string sentences = string.Join(" ", trimmedWords);
            sentences = sentences.TrimEnd();
			
            if (!string.IsNullOrWhiteSpace(sentences))
			{
				sentences += ".";
			}


			return sentences;
            
           
            
            

			
			 
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
			if (elements == null || elements.Count < 4)
			{
				return new double[0];
			}

			List<double> result = new List<double>();
			for (int i = 3; i < elements.Count; i += 4)
			{
				result.Add(elements[i]);
			}

			return result.ToArray();

		}
	

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
			HashSet<int> visited = new HashSet<int>();

			for (int i = 0; i < nums.Length; i++)
			{
				int complement = targetNumber - nums[i];
				if (visited.Contains(complement))
				{
					return true;
				}
				visited.Add(nums[i]);
			}

			return false;
		}
    }
}

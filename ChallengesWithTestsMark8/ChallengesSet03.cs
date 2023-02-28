using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {//throw new NotImplementedException();
            if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {//throw new NotImplementedException();
            if (numbers == null ||numbers.Count() == 0  ) 
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {//throw new NotImplementedException();
            var numberChar = false;
            var upperChar = false;
            var lowerChar = false;
            for (int word = 0; word < password.Length; word++)
            {
                if (char.IsUpper(password[word]))
                {
                    numberChar = true;
                }
                if (char.IsLower(password[word]))
                {
                    lowerChar = true;
                }
                if (char.IsDigit(password[word]))
                {
                    upperChar = true;
                }
            }
                if (numberChar == true && lowerChar == true && upperChar == true)
                { 
                    return true; 
                }
                else 
                {
                    return false;
                }
            
            
            
            


        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor is  0m)
            {
                return 0m;
            }
            var divide = dividend / divisor;
            return divide;
        }

        public int LastMinusFirst(int[] nums)
        {//throw new NotImplementedException();
            var length = nums.Last();
            var numbs = nums[0];
            var lastMinusFirst = length - numbs;
            return lastMinusFirst;
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            
            var below100 = new int[100];
             
            for (int i = 0; i >= below100.Length; i++)
            {
                below100[] = i;                
                      
            }
            return below100;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {//throw new NotImplementedException();
            foreach (var word in words)
            {word.ToString().ToUpper(); }
        }
    }
}

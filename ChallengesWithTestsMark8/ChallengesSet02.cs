using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {return true;}
            else { return false;}
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            { return true; }
            else { return false; }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            { return true; }
            else { return false; }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {   
            if (numbers == null ) { return 0; }
            if (numbers.Count() == 0) { return 0; }
            var min = numbers.Min();
            var max = numbers.Max();
            var sumOf = min + max;
            return sumOf;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length) 
            { return str1.Length  ; }
            else { return str2.Length; }
         
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) 
            { return 0; }
            return Enumerable.Sum(numbers);
            
         
        }


        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var results = 0;
                for( int num = 0; num < numbers.Length; num++ ) 
            {if (numbers[num] % 2 == 0)
                {
                    results += numbers[num];
                }
            }
             return results;
            
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            {
                return false; 
             }

           var sum = 0;
            for (int num = 0; num < numbers.Count; num++)
            {
                sum += numbers[num];
            }
            if (sum % 2 != 0) 
            {
            return true;
            }else { return false; }
            
            
            
            
            
            /*var results = 0;
            for(int num = 0; num < numbers.Count;num++ )
            {
                if (num % 2 == 0)
                {
                    results += numbers[num];
                }
                else if (results % 2 == 0) 
                { return true; }
                else { return false; }
                
            }*/
            
            







        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            // throw new NotImplementedException();
            /* for (int i = 0; i < number; i++)
             {
                 if (number % 2 != 0 && number >= 0) { return number; }
             }
             return number;*/
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }  
        }
    }
}

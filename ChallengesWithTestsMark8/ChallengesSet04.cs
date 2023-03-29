using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {//throw new NotImplementedException();
            var even = 0;
            var odd = 0;
            foreach (var num in numbers) 
            {
                if (num % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd -= num;
                }
            }
            return even + odd;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {//throw new NotImplementedException();
            var minumum = new List<string>() { str1, str2, str3, str4 };
            var shortest = minumum.Min(x => x.Length);
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {//throw new NotImplementedException();
           var lowest = new List<int>() { number1, number2, number3,number4 };
            var smallest = lowest.Min();
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {//throw new NotImplementedException();
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {//throw new NotImplementedException();
            return
                (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
                );
        }

        public bool IsStringANumber(string input)
        {
            var num = double.TryParse(input, out double number);
            return num;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
           var num = objs.Length;
            var majority = (num/2)+1;

            var count = 0;
            foreach ( var obj in objs ) 
            {
            if (obj == null ) 
                {
                   count++;
                }
            }
            if (count >= majority) 
            {
                return true;
            }else return false;
        }

        public double AverageEvens(int[] numbers)
        {//throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0) { return 0; }

            var num = numbers.Where(x => x % 2 == 0);
            if (num.Count() == 0 ) return 0;
            return num.Average();
            
        }

        public int Factorial(int number)
        {
            if ( number == 0 ) return 1;
            return number * Factorial(number - 1);
        }
    }
}

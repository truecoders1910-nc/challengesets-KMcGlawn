using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
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
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
               
                if (numbers[i] > numbers[i+1])
                {
                    return false;
                }
                                
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; ++i)
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
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string completeSentence = "";

            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    completeSentence += word.Trim() + " ";
                }
            }
            if (completeSentence.Length == 0)
            {
                return "";
            }
            completeSentence = completeSentence.Substring(0, completeSentence.Length - 1);
            completeSentence += ".";
            return completeSentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] ElementNeeded = new double[0];
            if (elements == null)
            {
                return ElementNeeded;
            }
            return elements.Where((x, i) =>  i % 4 == 3).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        int sum = nums[i] + nums[j];
                        if (sum == targetNumber)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string letter = c.ToString();

            if (letter == "A")
            {
                return true;
            }
            if (letter == "B")
            {
                return true;
            }
            if (letter == "C")
            {
                return true;
            }
            if (letter == "D")
            {
                return true;
            }
            if (letter == "E")
            {
                return true;
            }
            if (letter == "F")
            {
                return true;
            }
            if (letter == "G")
            {
                return true;
            }
            if (letter == "H")
            {
                return true;
            }
            if (letter == "I")
            {
                return true;
            }
            if (letter == "J")
            {
                return true;
            }
            if (letter == "K")
            {
                return true;
            }
            if (letter == "L")
            {
                return true;
            }
            if (letter == "M")
            {
                return true;
            }
            if (letter == "N")
            {
                return true;
            }
            if (letter == "O")
            {
                return true;
            }
            if (letter == "P")
            {
                return true;
            }
            if (letter == "Q")
            {
                return true;
            }
            if (letter == "R")
            {
                return true;
            }
            if (letter == "S")
            {
                return true;
            }
            if (letter == "T")
            {
                return true;
            }
            if (letter == "U")
            {
                return true;
            }
            if (letter == "V")
            {
                return true;
            }
            if (letter == "W")
            {
                return true;
            }
            if (letter == "X")
            {
                return true;
            }
            if (letter == "Y")
            {
                return true;
            }
            if (letter == "Z")
            {
                return true;
            }

            if (letter == " ")
            {
                return true;
            }
            if (letter == "a")
            {
                return true;
            }
            if (letter == "b")
            {
                return true;
            }
            if (letter == "c")
            {
                return true;
            }
            if (letter == "d")
            {
                return true;
            }
            if (letter == "e")
            {
                return true;
            }
            if (letter == "f")
            {
                return true;
            }
            if (letter == "g")
            {
                return true;
            }
            if (letter == "h")
            {
                return true;
            }
            if (letter == "i")
            {
                return true;
            }
            if (letter == "j")
            {
                return true;
            }
            if (letter == "k")
            {
                return true;
            }
            if (letter == "l")
            {
                return true;
            }
            if (letter == "m")
            {
                return true;
            }
            if (letter == "n")
            {
                return true;
            }
            if (letter == "o")
            {
                return true;
            }
            if (letter == "p")
            {
                return true;
            }
            if (letter == "q")
            {
                return true;
            }
            if (letter == "r")
            {
                return true;
            }
            if (letter == "s")
            {
                return true;
            }
            if (letter == "t")
            {
                return true;
            }
            if (letter == "u")
            {
                return true;
            }
            if (letter == "v")
            {
                return true;
            }
            if (letter == "w")
            {
                return true;
            }
            if (letter == "x")
            {
                return true;
            }
            if (letter == "y")
            {
                return true;
            }
            if (letter == "z")
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            if (vals.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                


        }


    

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            if (number == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            double sum;
          
            sum = numbers.Min() + numbers.Max();

            return sum;
           

            
            
           
            
            
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            
            if (str1.Length >= str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

           int add = numbers.Sum();
            return add;
        }

        public int SumEvens(int[] numbers)
        {
            
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0 )
            {
                return true;
            }
           
                return false;
           
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0)
            {
                return number % 2 == 0 ? number / 2 : (number - 1) / 2;
            }
            return 0;
        }
    }
}

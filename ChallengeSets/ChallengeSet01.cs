﻿using System;
namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            return false;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 <= number2)
            {
                return number1;
            }
            return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            long product = factor1 * factor2;
            return product;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            

            else
            {
                return $"Hello, {nameOfPerson}!";
            }

        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue < business.TotalExpenses)
                {
                    sum += 1;
                }
            }
            return sum;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            var busList = businesses.Where(x => x.TotalRevenue - x.TotalExpenses > 0).Select(x => x.Name);
            return String.Join(",", busList);

        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            if (business.ParentCompany == null)
            {
                return business.Name;
            }
            business.Name = GetNameOfHighestParentCompany(business.ParentCompany);
            return business.Name;

        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                if (finalBoard[i,0] == finalBoard[i,1] && finalBoard[i,1] == finalBoard[i,2])
                {
                    if (finalBoard[i,0] == 'O')
                    {
                        return TicTacToeResult.O;
                    }
                    if (finalBoard[i,0] == 'X')
                    {
                        return TicTacToeResult.X;
                    }
                }                
            }
            for (int i = 0; i < 3; i++)
            {
                if (finalBoard[0, i] == finalBoard[1, i] && finalBoard[1, i] == finalBoard[2, i])
                {
                    if (finalBoard[0,i] == 'O')
                    {
                        return TicTacToeResult.O;
                    }
                    if (finalBoard[0,i] == 'X')
                    {
                        return TicTacToeResult.X;
                    }
                }
            }
            if ((finalBoard[1,1] & finalBoard[2,2]) == finalBoard[0,0])
            {
                if (finalBoard[0,0] == 'O')
                {
                    return TicTacToeResult.O;
                }
                if (finalBoard[0,0] == 'X')
                {
                    return TicTacToeResult.X;
                }
            }
            if ((finalBoard[1,1] & finalBoard[2,0]) == finalBoard[0,2])
            {
                if (finalBoard[2,0] == 'O')
                {
                    return TicTacToeResult.O;
                }
                if (finalBoard[2,0] == 'X')
                {
                    return TicTacToeResult.X;
                }
            }
            return TicTacToeResult.Draw;
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers.Length == 0 || numbers == null)
            {
                return false;
            }

            int num = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] == targetNumber)
                    {
                        num += 1;
                        break;
                    }
                }

            }
            if (num == numbers.Length)
            {
                return true;
            }
            return false;
        }
    }
}

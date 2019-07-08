using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace Lucky7MVC.Models
{
    public class Calculator
    {
        public static Bet CalcWins(int iniBet)
        {
            Bet bet = new Bet();
            Random rand = new Random();
            bet.InitialBet = iniBet;
            bet.RInitialBet = iniBet;
            bet.RTotal = bet.RInitialBet;
            bet.RHighestAmountWon = iniBet;

            while (bet.RTotal != 0)
            {
                bet.RTotalRolls++;
                int rollOne;
                int rollTwo;
                int dieSum;
                rollOne = rand.Next(1, 7);
                rollTwo = rand.Next(1, 7);
                dieSum = rollOne + rollTwo;

                if (dieSum == 7)
                {
                    bet.RTotal += 4;
                    if (bet.RTotal > bet.RInitialBet)
                    {
                        bet.RInitialBet = bet.RTotal;
                        bet.RDieRollAtHighest = bet.RTotalRolls;
                        bet.RHighestAmountWon = bet.RTotal;
                    }
                }
                // If else the total is different subtract 1 from the total cash amount.
                else
                {
                    bet.RTotal -= 1;
                }
            }
            bet.RInitialBet = iniBet;
            return bet;
        }
    }
}
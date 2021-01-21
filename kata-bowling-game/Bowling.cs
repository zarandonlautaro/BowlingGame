using System;
using System.Collections.Generic;
using System.Text;

namespace kata_bowling_game
{
    public class Bowling
    {
        int score = 0;
        int backTurn;

        public int GetScore(int[,] turns)
        {
            for (int turn = 0; turn < turns.GetLength(0); turn++)
            {
                backTurn = turn - 1;
                // check if strike
                if (turn > 0 && turns[backTurn, 0] == 10)
                    score += turns[turn, 0] + turns[turn, 1];

                // check if spare
                else if (turn > 0 && turns[backTurn, 0] + turns[backTurn, 1] == 10)
                    score += turns[turn, 0];

                for (int lot = 0; lot < turns.GetLength(1); lot++)
                    score += turns[turn,lot];
            }
            return score;
        }
    }
}

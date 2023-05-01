namespace Bowling.Data;
using Bowling.Models;

public class ScoringEngine : IScoringEngine
{
     /* Function to score the rounds of a bowling game.
     If the current round is a strike, add 10 to the total score and add the next two frames' score to the total score.
     If the current round is a spare, add 10 to the total score and add the next frame's first ball to the total score.
     If the current round is not a strike or a spare, add the sum of the two balls to the total score.
     */
    public int CalculateScore(List<RoundScore> rounds)
    {
        int totalScore = 0;
    
        for (int i = 0; i < rounds.Count; i++)
        {
            RoundScore round = rounds[i];
    
            if (round.IsStrike)
            {
                totalScore += 10;
    
                if (i < 9)
                {
                    RoundScore nextRound = rounds[i + 1];
    
                    if (nextRound.IsStrike)
                    {
                        totalScore += 10;
    
                        if (i < 8)
                        {
                            RoundScore secondNextRound = rounds[i + 2];
                            totalScore += secondNextRound.IsStrike ? 10 : secondNextRound.FirstFrame;
                        }
                    }
                    else
                    {
                        totalScore += nextRound.FirstFrame + nextRound.SecondFrame;
                    }
                }
                else if (i == 9)
                {
                    totalScore += round.SecondFrame + round.BonusFrame;
    
                    if (round.BonusFrame == 10)
                    {
                        totalScore += 10;
                    }
                }
            }
            else if (round.IsSpare)
            {
                totalScore += 10;
    
                if (i < 9)
                {
                    RoundScore nextRound = rounds[i + 1];
                    totalScore += nextRound.FirstFrame;
                }
                else if (i == 9)
                {
                    totalScore += round.BonusFrame;
                }
            }
            else
            {
                totalScore += round.FirstFrame + round.SecondFrame;
            }
        }
    
        return totalScore;
    }
}
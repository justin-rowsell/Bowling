using Bowling.Models;

namespace Bowling.Data;

public interface IScoringEngine {
    int CalculateScore(List<RoundScore> rounds);
}
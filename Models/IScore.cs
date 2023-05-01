namespace Bowling.Models;
public interface IRoundScore {
    int RoundNumber { get; set; }
    int Score { get; set; }
    bool IsStrike { get; set; }
    bool IsSpare { get; set; }
    int FirstFrame { get; set; }
    int SecondFrame { get; set; }
    int BonusFrame { get; set; }
}
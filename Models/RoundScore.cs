namespace Bowling.Models;

public class RoundScore : IRoundScore {
    public RoundScore(int roundNumber) {
        this.RoundNumber = roundNumber;
        this.Score = 0;
        this.IsStrike = false;
        this.IsSpare = false;
    }
    public int RoundNumber { get; set; }
    public int Score { get; set; }
    public bool IsStrike { get; set; }
    public bool IsSpare { get; set; }
    public int FirstFrame { get; set; }
    public int SecondFrame { get; set; }
    public int BonusFrame { get; set; }

    public void AddPinsToFrame(int frame, int score) {
        if (frame == 1) {
            this.FirstFrame = score;
        } else {
            this.SecondFrame = score;
        }
    }
}
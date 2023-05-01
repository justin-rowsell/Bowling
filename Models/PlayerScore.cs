namespace Bowling.Models;

public class PlayerScore {
    public PlayerScore() {
        this.Rounds = new List<RoundScore>();
        this.TotalScore = 0;
        this.Name = string.Empty;
        this.RefreshRounds();

    }
    public List<RoundScore> Rounds { get; set; }
    public int TotalScore { get; set; }
    public string Name { get; set; }

    private void RefreshRounds() {
        this.TotalScore = 0;
        this.Rounds = new List<RoundScore>();
        for (int i = 0; i < 10; i++) {
            this.Rounds.Add(new RoundScore(i + 1));
        }
    }
}
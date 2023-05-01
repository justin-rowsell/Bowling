# Overview
Blazor .NET app with the basic functionality to log the scores from the rounds of a bowling match and calculate the scores.

## How to run
Clone the repo and run the dontent run or dotnet watch command to run the app locally (The dafault port is 5049).

## Considerations for future releases
1. Add front end validation to dynamically prevent users from entering more than 10 points for a given round.
2. Dynamically calculate scores as rounds are being entered.
3. Additional validation on the players' score cards before allowing the user to score the game.

## Notes on where to start looking through the code
1. The landing page for the scoring is in the Scoring.razor component under the Pages folder.
2. The Scoring component allows users to select how many players are in the match.
3. Each player will scaffold out a score card component. To look more into the logic and bindings of the score card model with the UI, see the ScoreCard.razor component under the Shared folder.
4. Simple data models can be found in the Models folder.
5. The logic to actually score a game can be found in the Scoring Engine in the Data folder. How this is used, is after the user fills out the scores, the TotalScore is set on each user by passing the list of ordered rounds to the scoring engine to return the total score.
6. The collection of player scores is then passed to the Leaderboard.razor component to show the winner.
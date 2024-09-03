using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q4TournamentWinner
    {
        // O(n) time and space
        public string TournamentWinnerFirst(List<List<string>> competitions, List<int> results)
        {
            var teamScores = new Dictionary<string, int>();
            string tournmentWinner = string.Empty;
            for (var i = 0; i < competitions.Count; i++)
            {
                var competition = competitions[i];
                var winner = results[i] == 1 ? competition[0] : competition[1];
                teamScores[winner] = teamScores.ContainsKey(winner) ? ++teamScores[winner] : 1;
                if (i == 0)
                    tournmentWinner = winner;
                else
                    if (teamScores[tournmentWinner] < teamScores[winner])
                    tournmentWinner = winner;
            }
            return tournmentWinner;
        }

        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            var teamScores = new Dictionary<string, int>();
            string tournmentWinner = string.Empty;
            for (var i = 0; i < competitions.Count; i++)
            {
                var winner = results[i] == 1 ? competitions[i][0] : competitions[i][1];
                teamScores[winner] = teamScores.ContainsKey(winner) ? ++teamScores[winner] : 1;
                if (i == 0)
                    tournmentWinner = winner;
                else
                    if (teamScores[tournmentWinner] < teamScores[winner])
                        tournmentWinner = winner;
            }
            return tournmentWinner;
        }
    }
}
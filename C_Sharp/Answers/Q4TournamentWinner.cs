using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q4TournamentWinner
    {
        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            var teamScores = new Dictionary<string, int>();
            string tournmentWinner = string.Empty;          
            for (var i = 0; i < competitions.Count; i++)
            {
                var competition = competitions[i];
                var winner = results[i] == 1 ? competition[0] : competition[1];
                //Console.WriteLine($"{competition[0]} vs {competition[1]} => {winner}");
                if (teamScores.ContainsKey(winner))
                {
                    teamScores[winner] = ++teamScores[winner];
                }
                else
                {
                    teamScores[winner] = 1;
                }
                if (i == 0)
                {
                    tournmentWinner = winner;
                }
                else
                {
                    if (teamScores[tournmentWinner] < teamScores[winner])
                        tournmentWinner = winner;
                }
            }

            return tournmentWinner;
        }
    }
}
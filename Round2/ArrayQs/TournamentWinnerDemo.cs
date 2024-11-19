using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_2.ArrayQs
{
    internal class TournamentWinnerDemo
    {
        /*         
         *         [Home,Away]
         *         [1] - Home win
         *         [0] - away win
      
            competitions = [[HTML, C#],[C#, Python], [Python, HTML]]
            results = [0,0,1]

            C# beats HTML               HTML = 0, C# = 1, Python = 0
            Python beats C#             HTML = 0, C# = 1, Python = 1
            Pyhton beats HTML           HTML = 0, C# = 1, Python = 2
        winner => python
         */
        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            var winner = string.Empty;
            var maxWinCount = 0;
            var winCountWithTeams = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                var teams = competitions[i];
                var result = results[i];
                if (result == 1)
                {
                    // home win
                    if (winCountWithTeams.ContainsKey(teams[0]))
                    {
                        winCountWithTeams[teams[0]] = winCountWithTeams[teams[0]] + 1;
                    }
                    else
                    {
                        winCountWithTeams[teams[0]] = 1;
                    }

                    if (winCountWithTeams[teams[0]] > maxWinCount)
                    {
                        maxWinCount = winCountWithTeams[teams[0]];
                        winner = teams[0];
                    }
                }
                else
                {
                    // away win
                    if (winCountWithTeams.ContainsKey(teams[1]))
                    {
                        winCountWithTeams[teams[1]] = winCountWithTeams[teams[1]] + 1;
                    }
                    else
                    {
                        winCountWithTeams[teams[1]] = 1;
                    }
                    if (winCountWithTeams[teams[1]] > maxWinCount)
                    {
                        maxWinCount = winCountWithTeams[teams[1]];
                        winner = teams[1];
                    }
                }
                
            }
            return winner;
        }

        public static string TournamentWinnerOpt(List<List<string>> competitions, List<int> results)
        {
            var currentWinner = string.Empty;
            var maxWinCount = 0;
            var winCountWithTeams = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                var homeTeam = competitions[i][0];
                var awayTeam = competitions[i][1];
                var winningTeam = results[i] == 1 ? homeTeam : awayTeam;
                if (!winCountWithTeams.ContainsKey(winningTeam))
                {
                    // add winning team iv not there
                    winCountWithTeams.Add(winningTeam, 0);
                }
                winCountWithTeams[winningTeam]++;       // increase win count

                
                if(maxWinCount < winCountWithTeams[winningTeam])
                {
                    maxWinCount = winCountWithTeams[winningTeam];
                    currentWinner = winningTeam;
                }

            }
            return currentWinner;
        }
    }
}

namespace Round3_29_01_2025
{
    internal static class _4_TournamentWinner
    {
        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            var i = 0;
            var dictionary = new Dictionary<string, int>();
            var winner = string.Empty;
            while(i < results.Count)
            {
                var currentWinner = results[i] == 1 ? competitions[i][0] : competitions[i][1];
                if (dictionary.ContainsKey(currentWinner))
                {
                    dictionary[currentWinner]++;
                }
                else
                {
                    dictionary.Add(currentWinner, 1);
                }

                if (winner == string.Empty || dictionary[currentWinner] > dictionary[winner])
                {
                    winner = currentWinner;
                }

                ++i;
            }
            return winner;
        }
    }
}

namespace Round3_29_01_2025
{
    public class IsomorphicStrings
    {
        // "Given two strings s and t, determine if they are isomorphic. Two strings s and t are isomorphic if the characters in s can be replaced to get t.
        // All occurrences of a character must be replaced with another character while preserving the order of characters.
        // //No two characters may map to the same character, but a character may map to itself.s and t consist of any valid ascii character. "
        // abacus, rirfgs => true
        // aba, pqr => false
        // ababr, eoeoo => false
        // ababr, pqrqo => false
        // green, abccd => true
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> dict = new ();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i])
                        return false;
                }
                else
                {
                    dict[s[i]] = t[i];
                }
            }
            return true;
        }
    }
}

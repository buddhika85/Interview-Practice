namespace Round3_29_01_2025
{
    public class IsomorphicStrings
    {
        // "Given two strings s and t, determine if they are isomorphic. Two strings s and t are isomorphic if the characters in s can be replaced to get t.
        // All occurrences of a character must be replaced with another character while preserving the order of characters.
        // //No two characters may map to the same character, but a character may map to itself.s and t consist of any valid ascii character. "
        // abacus, rirfgs => true
        // green, abccd => true
        // aba, pqr => false
        // ababr, eoeoo => false
        // ababr, pqrqo => false

        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> dictST = new ();
            Dictionary<char, char> dictTS = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (dictST.ContainsKey(s[i]))
                {
                    if (dictST[s[i]] != t[i])
                        return false;
                }
                else
                {
                    dictST[s[i]] = t[i];
                }

                if (dictTS.ContainsKey(t[i]))
                {
                    if (dictTS[t[i]] != s[i])
                        return false;
                }
                else
                {
                    dictTS[t[i]] = s[i];
                }
            }
            return true;
        }
    }
}

namespace Round3_29_01_2025
{
    // You are given a string consisting of only lower case and upper-case English Alphabets and integers 0 to 9.
    // Write a function that will take this string as Input and return the index of the first character that is non-repeating.

    public class NonRepeatingChar
    {
        public char FirstNonRepeatingChar(string str)
        {
            var dict = new Dictionary<char, bool>();
            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict.Remove(c);
                }
                else
                {
                    dict.Add(c, true);  
                }
            }
            return dict.FirstOrDefault().Key;
        }
    }
}

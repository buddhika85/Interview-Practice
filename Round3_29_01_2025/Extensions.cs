namespace Round3_29_01_2025
{
    public static class Extensions
    {
        public static string DisplayableString(this int[] array, char separator)
        {
            return string.Join(separator, array);
        }
    }
}

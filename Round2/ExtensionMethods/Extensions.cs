namespace Round_2.ExtensionMethods
{
    public static class Extensions
    {
        public static string Join<T>(this IEnumerable<T> items, char separator)
        {
            return string.Join(separator, items);
        }
    }
}

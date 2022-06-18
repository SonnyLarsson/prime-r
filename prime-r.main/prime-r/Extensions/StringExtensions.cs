namespace prime_r
{
    static internal class StringExtensions
    {
        internal static string LastCharacter(this string s)
        {
            return s[s.Length - 1].ToString();
        }
    }
}

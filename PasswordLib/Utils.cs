namespace PasswordLib
{
    public class Utils
    {
        public static bool IsLower(char c) => char.IsLower(c);

        public static bool IsLower(char[] ch)
        {
            foreach (var c in ch)
            {
                if (char.IsLetter(c) && IsUpper(c))
                    return false;
            }
            return true;
        }

        public static bool IsLower(string str) => IsLower(str.ToArray());

        public static bool IsUpper(char c) => char.IsUpper(c);

        public static bool IsUpper(char[] ch)
        {
            foreach (var c in ch)
            {
                if (char.IsLetter(c) && IsLower(c))
                    return false;
            }
            return true;
        }

        public static bool IsUpper(string str) => IsUpper(str.ToArray());

        public static bool IsAlphabet(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    }
}

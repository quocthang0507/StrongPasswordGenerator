using System.Text;

namespace PasswordLib
{
    public class Password
    {
        private Random random;
        private int length = Constants.PASSWORD_LENGTH;
        private int max_NonAlphabetLength = Constants.NON_ALPHABET_LENGTH;
        private bool special_chars = true, upper_chars = true, lower_chars = true, numbers = true, similar_chars = true, easy_say = false, easy_read = false;
        private string yourString = "";

        public Password()
        {
            random = new Random(Guid.NewGuid().GetHashCode());
        }

        public Password(int length)
        {
            random = new Random(Guid.NewGuid().GetHashCode());
            this.length = length;
        }

        public Password(int length, int max_NonAlphabetLength)
        {
            random = new Random(Guid.NewGuid().GetHashCode());
            this.length = length;
            this.max_NonAlphabetLength = max_NonAlphabetLength;
        }

        public Password(int length, int max_NonAlphabetLength, bool special_chars, bool upper, bool lower, bool numbers, bool similar, bool easy_say, bool easy_read)
        {
            random = new Random(Guid.NewGuid().GetHashCode());
            this.length = length;
            this.max_NonAlphabetLength = max_NonAlphabetLength;
            this.special_chars = special_chars;
            this.upper_chars = upper;
            this.lower_chars = lower;
            this.numbers = numbers;
            this.similar_chars = similar;
            this.easy_say = easy_say;
            this.easy_read = easy_read;
        }

        private string GetRandomChars(char[] chars)
        {
            StringBuilder sb = new();
            int length = random.Next(1, max_NonAlphabetLength + 1);
            int i, j;
            for (i = 0; i < length; i++)
            {
                j = random.Next(chars.Length);
                sb.Append(chars[j]);
            }
            return sb.ToString();
        }

        private string GetRandomSpecialChars() => GetRandomChars(Constants.SPECIAL_CHARACTERS);

        private string GetRandomNumbers() => GetRandomChars(Constants.NUMBERS);

        private string TransformPassword(string originalPassword)
        {

        }

        /// <summary>
        /// https://rosettacode.org/wiki/Knuth_shuffle#C.23
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        private void KnuthShuffle<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length); // Don't select from the entire array on subsequent loops
                (array[j], array[i]) = (array[i], array[j]);
            }
        }

        public string GetPassword()
        {
            StringBuilder sb = new();

            for (int i = 0; i < length; i++)
            {

            }
            return sb.ToString();
        }
    }
}

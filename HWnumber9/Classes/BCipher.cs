using HWnumber9.Interfaces;
using System.Text;

namespace HWnumber9.Classes
{
    internal class BCipher : ICipher
    {
        #region Methods
        /// <summary>
        /// Метод для шифровки
        /// </summary>
        public string Encode(string input)
        {
            int shift = 1;
            StringBuilder encodedWord = new StringBuilder();

            foreach (char c in input)
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char encodedChar = (char)((c + shift - offset + 26) % 26 + offset);
                encodedWord.Append(encodedChar);
            }
            return encodedWord.ToString();
        }

        /// <summary>
        /// Метод для расшифровки
        /// </summary>
        public string Decode(string input)
        {
            int shift = 1;
            StringBuilder decodedWord = new StringBuilder();
            foreach (char c in input)
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char encodedChar = (char)((c - shift - offset + 26) % 26 + offset);
                decodedWord.Append(encodedChar);
            }
            return decodedWord.ToString();
        }
        #endregion
    }
}

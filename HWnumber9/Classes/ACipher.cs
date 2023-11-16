using HWnumber9.Interfaces;
using System.Text;

namespace HWnumber9.Classes
{
    public class ACipher : ICipher
    {
        int shift = 1;

        #region Methods
        /// <summary>
        /// Метод для шифровки слова 
        /// </summary>
        public string Encode(string input)
        {
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
        /// Метод для расшифровки слова 
        /// </summary>
        public string Decode(string input)
        {
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

using System;
using System.Text;

namespace TiLab1
{
    public class VigenerChiper : Chiper
    {
        public override string Encrypt(string originalText, string secretKey)
        {
            StringBuilder result = new StringBuilder();

            int abcLength = abc.Length;
            string upperOriginalText = originalText.ToUpper();
            string upperSecretKey = secretKey.ToUpper();

            string newSecretKey = GenerateSecretKeyRelativeToInputString(upperOriginalText, upperSecretKey);

            for (int i = 0; i < upperOriginalText.Length; i++)
            {
                if (upperOriginalText[i] == ' ')
                {
                    result.Append(upperOriginalText[i]);
                    continue;
                }

                int p = GetIndexRelativeToABC(upperOriginalText[i]);
                int k = GetIndexRelativeToABC(newSecretKey[i]);
                int charIndex = (p + k) % abcLength;
                result.Append(GetCharFromABCByIndex(charIndex));
            }

            return result.ToString();
        }

        public override string Decrypt(string encryptingText, string secretKey)
        {
            StringBuilder result = new StringBuilder();
            int abcLength = abc.Length;
            string upperEncryptingText = encryptingText.ToUpper();
            string upperSecretKey = secretKey.ToUpper();

            for (int i = 0; i < upperEncryptingText.Length; i++)
            {
                if (upperEncryptingText[i] == ' ')
                {
                    result.Append(upperEncryptingText[i]);
                    continue;
                }
               
                int c = GetIndexRelativeToABC(upperEncryptingText[i]);
                int k;
                if (i >= upperSecretKey.Length)
                {
                     k = GetIndexRelativeToABC(result[(i - upperSecretKey.Length)]);
                }
                else
                {
                     k = GetIndexRelativeToABC(upperSecretKey[i]);
                }
                int charIndex = (c - k + abcLength) % abcLength;
                result.Append(GetCharFromABCByIndex(charIndex));
            }

            return result.ToString();
        }

        private int GetIndexRelativeToABC(char inputChar)
        {
            return abc.IndexOf(inputChar);
        }

        private char GetCharFromABCByIndex(int index)
        {
            if (index >= abc.Length) throw new ArgumentOutOfRangeException("index");
            return abc[index];
        }

        private string GenerateSecretKeyRelativeToInputString(string inputString, string secretKey)
        {
            StringBuilder result = new StringBuilder();

            string inputStringWithOutSpace = inputString.Replace(" ", "");
            for (int i = 0; i < inputString.Length; i++)
            {
                if (i >= secretKey.Length)
                {
                    int index = (i - secretKey.Length) % inputStringWithOutSpace.Length;
                    result.Append(inputStringWithOutSpace[index]);
                }
                else
                {
                    result.Append(secretKey[i]);
                }
    
            }
            return result.ToString();
        }
    }
}

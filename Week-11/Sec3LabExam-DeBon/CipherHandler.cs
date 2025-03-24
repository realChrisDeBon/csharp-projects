using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec3LabExam_DeBon
{
    public static class CipherHandler
    {
        public static int convertedMessages = 0;

        private static readonly Dictionary<char, char> PlainToCipher = new Dictionary<char, char>
        {
            {'A', 'R'}, {'B', 'S'}, {'C', 'N'}, {'D', 'E'}, {'E', 'P'}, {'F', 'H'}, {'G', 'C'}, {'H', 'A'},
            {'I', 'T'}, {'J', 'I'}, {'K', 'M'}, {'L', 'G'}, {'M', 'L'}, {'N', 'X'}, {'O', 'W'}, {'P', 'V'},
            {'Q', 'F'}, {'R', 'U'}, {'S', 'J'}, {'T', 'Z'}, {'U', 'K'}, {'V', 'O'}, {'W', 'B'}, {'X', 'Y'},
            {'Y', 'D'}, {'Z', 'Q'}
        };

        private static readonly Dictionary<char, char> CipherToPlain = PlainToCipher.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

        public static string Encode(string input)
        {
            return Transform(input, PlainToCipher);
        }

        public static string Decode(string input)
        {
            return Transform(input, CipherToPlain);
        }

        private static string Transform(string input, Dictionary<char, char> transformationDictionary)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input.ToUpper())
            {
                if (transformationDictionary.ContainsKey(c))
                {
                    result.Append(transformationDictionary[c]);
                }
                else
                {
                    result.Append(c);
                }
            }
            convertedMessages++;
            return result.ToString();
        }
    }
}

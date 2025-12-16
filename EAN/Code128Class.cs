using System;
using System.Text;
using System.Text.RegularExpressions;

namespace EAN
{
    public static class Code128Class
    {
        // Encodation tables for Code128B (best for Student IDs)
        private static readonly string[] Code128B =
        {
            " ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",",
            "-", ".", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F",
            "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S",
            "T", "U", "V", "W", "X", "Y", "Z", "[", "\\", "]", "^", "_",
            "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
            "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y",
            "z", "{", "|", "}", "~", "DEL"
        };

        // Returns barcode string for Code128B
        public static string EncodeB(string data)
        {
            int sum = 104; // Start code for Code128B
            StringBuilder result = new StringBuilder();
            result.Append((char)204); // Start B

            for (int i = 0; i < data.Length; i++)
            {
                int index = Array.IndexOf(Code128B, data[i].ToString());
                if (index < 0)
                {
                    throw new Exception($"Character '{data[i]}' not supported in Code128B");
                }

                sum += (index * (i + 1));
                result.Append((char)(index + 32));
            }

            int checksum = sum % 103;
            result.Append((char)(checksum + 32)); // checksum char

            result.Append((char)206); // Stop code

            return result.ToString();
        }
    }
}

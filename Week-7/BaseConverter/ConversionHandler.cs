using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    public static class ConversionHandler
    {
        public static mainForm formReference { get; set; }

        // check if the input is a valid number in the specified base
        public static bool IsValidBase(string input)
        {
            return int.TryParse(input, out int result) && result >= 2 && result <= 16;
        }

        public static void ResetBase()
        {
            formReference.txt_baseof.Text = ""; // reduce down to placeholder text
            formReference.txt_baseof.Focus();
        }

        public static void ConvertToBase(int number, int targetBase)
        {
            if (targetBase < 2 || targetBase > 16)
            {
                throw new ArgumentOutOfRangeException(nameof(targetBase), "Base must be in the range 2-16.");
            }

            const string chars = "0123456789ABCDEF";
            StringBuilder result = new StringBuilder();

            int currentNumber = number;
            while (currentNumber > 0)
            {
                int remainder = currentNumber % targetBase;
                result.Insert(0, chars[remainder]);
                currentNumber /= targetBase;
            }

            string prefix = targetBase == 16 ? "0x" : $"{targetBase}x";
            formReference.lbl_result.Text = prefix + result.ToString();
        }
    }
}

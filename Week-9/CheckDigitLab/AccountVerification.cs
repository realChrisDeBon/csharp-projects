using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDigitLab
{
    public static class AccountVerification
    {
        public static string GenerateValidAccountNumber()
        {
            Random random = new Random();
            StringBuilder accountNumberBuilder = new StringBuilder();

            for (int i = 0; i < 7; i++)
            {
                accountNumberBuilder.Append(random.Next(0, 10));
            }
            string firstSevenDigits = accountNumberBuilder.ToString();
            int checkDigit = CalculateCheckDigit(firstSevenDigits);
            accountNumberBuilder.Append(checkDigit);

            return accountNumberBuilder.ToString();
        }


        public static bool ValidateAccountNumber(string accountNumber, string confirmAccountNumber, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(accountNumber) || string.IsNullOrWhiteSpace(confirmAccountNumber))
            {
                errorMessage = "Account number and confirmation cannot be empty.";
                return false;
            }

            if (!accountNumber.All(char.IsDigit) || !confirmAccountNumber.All(char.IsDigit))
            {
                errorMessage = "Account number and confirmation must be numeric.";
                return false;
            }

            if (accountNumber != confirmAccountNumber)
            {
                errorMessage = "Account number and confirmation do not match.";
                return false;
            }

            if (!IsValidCheckDigit(accountNumber))
            {
                errorMessage = "Invalid account number. Check digit does not match.";
                return false;
            }

            return true;
        }


        public static bool ValidatePaymentAmount(string paymentAmount, out string errorMessage)
        {
            errorMessage = string.Empty;
            string payment = paymentAmount;

            if(paymentAmount.StartsWith("$"))
            {
                payment = paymentAmount.Substring(1);
            }

            if (string.IsNullOrWhiteSpace(payment))
            {
                errorMessage = "Payment amount cannot be empty.";
                return false;
            }

            if (!decimal.TryParse(payment, out _))
            {
                errorMessage = "Payment amount must be a valid number.";
                return false;
            }

            return true;
        }

        public static int CalculateCheckDigit(string accountNumber)
        {
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                int digit = int.Parse(accountNumber[i].ToString());
                sum += digit;
            }

            return sum % 10;
        }


        public static bool IsValidCheckDigit(string accountNumber)
        {
            if (accountNumber.Length != 8)
            {
                return false;
            }

            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                if (!char.IsDigit(accountNumber[i]))
                {
                    return false;
                }
                sum += int.Parse(accountNumber[i].ToString());
            }

            int checkDigit = sum % 10;
            return checkDigit == int.Parse(accountNumber[7].ToString());
        }

    }
}

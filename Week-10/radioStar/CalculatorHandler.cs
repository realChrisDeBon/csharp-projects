using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radioStar
{
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Modulus
    }

    public static class CalculatorHandler
    {
        private const string nonVerbosePrefix = "The Answer is: ";
        public static Operation CurrentOperations { get; set; } = Operation.Add;

        private static readonly Dictionary<Operation, Func<double, double, double>> operations = new Dictionary<Operation, Func<double, double, double>>
        {
            { Operation.Add, (x, y) => x + y },
            { Operation.Subtract, (x, y) => x - y },
            { Operation.Multiply, (x, y) => x * y },
            { Operation.Divide, (x, y) => x / y },
            { Operation.Modulus, (x, y) => x % y }
        };

        private static readonly Dictionary<Operation, string> operationSymbols = new Dictionary<Operation, string>
        {
            { Operation.Add, "+" },
            { Operation.Subtract, "-" },
            { Operation.Multiply, "*" },
            { Operation.Divide, "/" },
            { Operation.Modulus, "%" }
        };

        private static bool VerboseAnswer => Program.mainform.optionVerbosity.Checked;
        private static string FirstNumber => Program.mainform.leftOperandTxt.Text.ToString();
        private static string SecondNumber => Program.mainform.rightOperandTxt.Text.ToString();

        public static void Calculate_Click(object sender, EventArgs e)
        {
            double _ = ExecuteOperation(out bool valid);
            if(valid)
                SetAnswer(_);
        }

        public static void SetAnswer(double result)
        {
            // ternarily set the main label text
           Program.mainform.msgOutLbl.Text = VerboseAnswer ? $"{FirstNumber} {operationSymbols[CurrentOperations]} {SecondNumber} = {result}" : $"{nonVerbosePrefix}{result}";
        }

        public static double ExecuteOperation(out bool valid)
        {
            valid = true;
            // empty string checks
            if (string.IsNullOrWhiteSpace(FirstNumber))
            {
                Program.mainform.BeginInvoke(new Action(() =>
                {
                    int x = Program.mainform.leftOperandTxt.Width / 2;
                    int y = Program.mainform.leftOperandTxt.Height / 2;
                    Program.mainform.errorTooltip.Show("Please enter a valid number.", Program.mainform.leftOperandTxt, x, y, 3000);
                }));
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(SecondNumber))
            {
                Program.mainform.BeginInvoke(new Action(() =>
                {
                    int x = Program.mainform.rightOperandTxt.Width / 2;
                    int y = Program.mainform.rightOperandTxt.Height / 2;
                    Program.mainform.errorTooltip.Show("Please enter a valid number.", Program.mainform.rightOperandTxt, x, y, 3000);
                }));
                valid = false;
            }

            if (!double.TryParse(FirstNumber, out double leftValue))
            {
                Program.mainform.BeginInvoke(new Action(() =>
                {
                    int x = Program.mainform.leftOperandTxt.Width / 2;
                    int y = Program.mainform.leftOperandTxt.Height / 2;
                    Program.mainform.errorTooltip.Show("Invalid character.", Program.mainform.leftOperandTxt, x, y, 3000);
                }));
                Program.mainform.leftOperandTxt.Focus();
                valid = false;
            }

            if (!double.TryParse(SecondNumber, out double rightValue))
            {
                Program.mainform.BeginInvoke(new Action(() =>
                {
                    int x = Program.mainform.rightOperandTxt.Width / 2;
                    int y = Program.mainform.rightOperandTxt.Height / 2;
                    Program.mainform.errorTooltip.Show("Invalid character.", Program.mainform.rightOperandTxt, x, y, 3000);
                }));
                Program.mainform.rightOperandTxt.Focus();
                valid = false;
            }

            // Check if either value is zero or zero-decimal-zero
            if ((leftValue == 0)&&(valid == true))
            {
                Program.mainform.BeginInvoke(new Action(() =>
                {
                    int x = Program.mainform.leftOperandTxt.Width / 2;
                    int y = Program.mainform.leftOperandTxt.Height / 2;
                    Program.mainform.errorTooltip.Show("Value cannot be 0.", Program.mainform.leftOperandTxt, x, y, 3000);
                }));
                valid = false;
                return 0;
            }
            if ((rightValue == 0)&&(valid == true))
            {
                Program.mainform.BeginInvoke(new Action(() =>
                {
                    int x = Program.mainform.rightOperandTxt.Width / 2;
                    int y = Program.mainform.rightOperandTxt.Height / 2;
                    Program.mainform.errorTooltip.Show("Value cannot be 0.", Program.mainform.rightOperandTxt, x, y, 3000);
                }));
                valid = false;
                return 0;
            }

            return operations[CurrentOperations](leftValue, rightValue);
        }


    }
}

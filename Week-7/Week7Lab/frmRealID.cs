using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6MethodsProjectDL
{
    public partial class frmRealID : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmRealID()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }


        #region Main Method and Math Handling
        // unified button click event handler
        // every button's Tag property is set to a byte code, thereby
        // allowing us to determine the operation to perform rather than
        // having a separate event handler for each button
        private void buttonOperation_Click(object sender, EventArgs e)
            {
            // first validate
            if (!ValidateInputs())
            {
                return;
            }
            else
            {
                try
                {
                    Button clickedButton = (Button)sender;
                    byte operation = Convert.ToByte(clickedButton.Tag);

                    decimal dLeft = Convert.ToDecimal(txt_leftoperand.Text);
                    decimal dRight = Convert.ToDecimal(txt_rightoperand.Text);

                    decimal dAnswer = PerformOperation(dLeft, dRight, operation);
                    lbl_display.Text = $"{dLeft} {GetOperatorSymbol(operation)} {dRight} = {dAnswer}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK);
                }
            }
            }

        // validate the inputs, no unexpected exceptions should ever be thrown after this
        private static bool ValidateInputs()
        {
            string leftOperand = Program.frmMethodActing.txt_leftoperand.Text;
            string rightOperand = Program.frmMethodActing.txt_rightoperand.Text;

            bool goodpass = true;
            string returnstring = string.Empty;

            if ((string.IsNullOrEmpty(leftOperand)) || string.IsNullOrEmpty(rightOperand))
            {
                if (string.IsNullOrEmpty(leftOperand)){ Program.frmMethodActing.txt_leftoperand.Focus(); } else { Program.frmMethodActing.txt_rightoperand.Focus(); }
                returnstring += ("Please enter a value for both operands. ");
                goodpass = false;
            } 
            if ((leftOperand.Contains(".") && leftOperand.Count(c => c == '.') > 1) || (rightOperand.Contains(".") && rightOperand.Count(c => c == '.') > 1))
            {
                if(leftOperand.Contains(".")) { Program.frmMethodActing.txt_leftoperand.Focus(); } else { Program.frmMethodActing.txt_rightoperand.Focus(); }
                returnstring += ("Use of more than one . is prohibited. ");
                goodpass = false;
            } 
            if (leftOperand == "0" || rightOperand == "0")
            {
                if(leftOperand == "0") { Program.frmMethodActing.txt_leftoperand.Focus(); } else { Program.frmMethodActing.txt_rightoperand.Focus(); }
                returnstring += ("0 is not a valid value for either operand. ");
                goodpass = false;
            }
            if(((!leftOperand.Any(char.IsDigit)) && (leftOperand.Contains("."))) || ((!rightOperand.Any(char.IsDigit))&&(rightOperand.Contains("."))))
            {
                if (!leftOperand.Any(char.IsDigit)) { Program.frmMethodActing.txt_leftoperand.Focus(); } else { Program.frmMethodActing.txt_rightoperand.Focus(); }
                returnstring += ("Please enter atleast one valid number. ");
                goodpass = false;
            }

            if (!goodpass)
            {
                Program.frmMethodActing.PushMessage(returnstring);
                return false;
            }

            return true;
        }

        // get an operator symbol based on the byte code
        private string GetOperatorSymbol(byte operation)
            {
            switch (operation)
                {
                case 0:
                    return "+";
                case 1:
                    return "-";
                case 2:
                    return "*";
                case 3:
                    return "/";
                case 4:
                    return "%";
                default:
                    return "?";
                }

            }
        // single method to perform the operation
        private decimal PerformOperation(decimal leftOperand, decimal rightOperand, byte operation)
            {
            switch (operation)
                {
                case ADD:
                    return leftOperand + rightOperand;
                case SUBTRACT:
                    return leftOperand - rightOperand;
                case MULTIPLY:
                    return leftOperand * rightOperand;
                case DIVIDE:
                    return leftOperand / rightOperand;
                case MODULUS:
                    return leftOperand % rightOperand;
                default:
                    throw new ArgumentException("Invalid operation code.");
                }
            }
        #endregion

        private void PushMessage(string msg)
        {
            lbl_display.ForeColor = Color.Red;
            lbl_display.Text = msg;
            lbl_display.Tag = "1";
        }

        private void btn_exit_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void btn_clear_Click(object sender, EventArgs e)
            {
            txt_leftoperand.Text = String.Empty;
            txt_rightoperand.Text = String.Empty;
            lbl_display.Text = String.Empty;
            }

        private void frmMethodActing_Load(object sender, EventArgs e)
            {
            txt_rightoperand.Text = "10";
            txt_leftoperand.Text = "5";
            }

        private void NumericOrDecimalOnly_TextChanged(object sender, EventArgs e)
            {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Filter out invalid characters
            string filtered = new string(
                textBox.Text.Where(c => char.IsDigit(c) || c == '.').ToArray()
            );

            // If filtered text differs, replace the text and fix cursor position
            if (filtered != textBox.Text)
                {
                int oldPos = textBox.SelectionStart - (textBox.Text.Length - filtered.Length);
                textBox.Text = filtered;
                textBox.SelectionStart = Math.Max(oldPos, 0);
                }
            }
        }
}

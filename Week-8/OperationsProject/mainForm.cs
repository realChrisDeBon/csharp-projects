namespace OperationsProject
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            modulus_show.Click += BtnShowModulus_Click;
            factorial_show.Click += BtnShowFactorial_Click;
            fibonacci_show.Click += BtnShowFibonacci_Click;
            modulus_do.Click += BtnDoModulus_Click;
            factorial_do.Click += BtnDoFactorial_Click;
            fibonacci_do.Click += BtnDoFibonacci_Click;

            modulus_do.Enabled = false;
            factorial_do.Enabled = false;
            fibonacci_do.Enabled = false;
        }

        private void BtnShowModulus_Click(object sender, EventArgs e)
        {
            input_one.Visible = true;
            input_two.Visible = true;
            modulus_do.Enabled = true;
            factorial_do.Enabled = false;
            fibonacci_do.Enabled = false;
            result_output.Text = "Enter two integers for modulus operation.";
        }

        private void BtnShowFactorial_Click(object sender, EventArgs e)
        {
            input_one.Visible = true;
            input_two.Visible = false;
            modulus_do.Enabled = false;
            factorial_do.Enabled = true;
            fibonacci_do.Enabled = false;
            result_output.Text = "Enter an integer for factorial operation.";
        }

        private void BtnShowFibonacci_Click(object sender, EventArgs e)
        {
            input_one.Visible = true;
            input_two.Visible = false;
            modulus_do.Enabled = false;
            factorial_do.Enabled = false;
            fibonacci_do.Enabled = true;
            result_output.Text = "Enter an integer for Fibonacci operation.";
        }

        private void BtnDoModulus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input_one.Text, out int num1) && int.TryParse(input_two.Text, out int num2))
            {
                if (num2 == 0)
                {
                    result_output.Text = "Cannot divide by zero.";
                    return;
                }

                int quotient = 0;
                int remainder = num1;

                while (remainder >= num2)
                {
                    remainder -= num2;
                    quotient++;
                }

                result_output.Text = $"{num1} divided by {num2} is {quotient} with a remainder of {remainder}.";
            }
            else
            {
                result_output.Text = "Please enter valid integers.";
            }
        }

        private void BtnDoFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input_one.Text, out int num))
            {
                if (num < 0 || num > 15)
                {
                    result_output.Text = "Please enter a number between 0 and 15.";
                    return;
                }

                long factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }

                result_output.Text = $"The answer to {num}! is {factorial}.";
            }
            else
            {
                result_output.Text = "Please enter a valid integer.";
            }
        }

        private long Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        private void BtnDoFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input_one.Text, out int num))
            {
                if (num < 0)
                {
                    result_output.Text = "Please enter a number between 0 and 45.";
                    return;
                }

                if (num == 0)
                {
                    result_output.Text = "Fibonacci(0) = 0";
                }
                else if (num == 1)
                {
                    result_output.Text = "Fibonacci(1) = 1";
                }
                else
                {
                    long fib_n = Fib(num);
                    long fib_n_minus_1 = Fib(num - 1);
                    long fib_n_minus_2 = Fib(num - 2);
                    result_output.Text = $"Fibonacci({num}) = Fibonacci({num - 1}) + Fibonacci({num - 2}) = {fib_n_minus_1} + {fib_n_minus_2} = {fib_n}";
                }
            }
            else
            {
                result_output.Text = "Please enter a valid integer.";
            }
        }

        private void exitbtn_click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this app!!", "Thanks!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            result_output.Text = string.Empty;
        }


    }
}

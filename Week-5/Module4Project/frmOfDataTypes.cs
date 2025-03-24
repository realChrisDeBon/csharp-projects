
namespace Module4Project
{
    public partial class frmOfDataTypes : Form
        {
        public frmOfDataTypes()
            {
            InitializeComponent();
            }

        private void InitializeComponent()
            {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnByte_Click = new Button();
            BtnShort_Click = new Button();
            BtnInt_Click = new Button();
            BtnLong_Click = new Button();
            BtnFloat_Click = new Button();
            BtnDouble_Click = new Button();
            BtnDecimal_Click = new Button();
            BtnPow_Click = new Button();
            BtnRound_Click = new Button();
            BtnSqrt_Click = new Button();
            BtnClear_Click = new Button();
            BtnExit_Click = new Button();
            lblDisplay = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDisplay, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(566, 390);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(BtnByte_Click, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnShort_Click, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnInt_Click, 2, 0);
            tableLayoutPanel2.Controls.Add(BtnLong_Click, 3, 0);
            tableLayoutPanel2.Controls.Add(BtnFloat_Click, 0, 1);
            tableLayoutPanel2.Controls.Add(BtnDouble_Click, 1, 1);
            tableLayoutPanel2.Controls.Add(BtnDecimal_Click, 2, 1);
            tableLayoutPanel2.Controls.Add(BtnPow_Click, 3, 1);
            tableLayoutPanel2.Controls.Add(BtnRound_Click, 0, 2);
            tableLayoutPanel2.Controls.Add(BtnSqrt_Click, 1, 2);
            tableLayoutPanel2.Controls.Add(BtnClear_Click, 2, 2);
            tableLayoutPanel2.Controls.Add(BtnExit_Click, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 81);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(560, 306);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnByte_Click
            // 
            BtnByte_Click.BackColor = Color.Silver;
            BtnByte_Click.Dock = DockStyle.Fill;
            BtnByte_Click.Location = new Point(3, 3);
            BtnByte_Click.Name = "BtnByte_Click";
            BtnByte_Click.Size = new Size(134, 70);
            BtnByte_Click.TabIndex = 0;
            BtnByte_Click.Text = "byte";
            BtnByte_Click.UseVisualStyleBackColor = false;
            BtnByte_Click.Click += BtnByte_Click_Click;
            // 
            // BtnShort_Click
            // 
            BtnShort_Click.BackColor = Color.Silver;
            BtnShort_Click.Dock = DockStyle.Fill;
            BtnShort_Click.Location = new Point(143, 3);
            BtnShort_Click.Name = "BtnShort_Click";
            BtnShort_Click.Size = new Size(134, 70);
            BtnShort_Click.TabIndex = 1;
            BtnShort_Click.Text = "Short";
            BtnShort_Click.UseVisualStyleBackColor = false;
            BtnShort_Click.Click += BtnShort_Click_Click;
            // 
            // BtnInt_Click
            // 
            BtnInt_Click.BackColor = Color.Silver;
            BtnInt_Click.Dock = DockStyle.Fill;
            BtnInt_Click.Location = new Point(283, 3);
            BtnInt_Click.Name = "BtnInt_Click";
            BtnInt_Click.Size = new Size(134, 70);
            BtnInt_Click.TabIndex = 2;
            BtnInt_Click.Text = "Int";
            BtnInt_Click.UseVisualStyleBackColor = false;
            BtnInt_Click.Click += BtnInt_Click_Click;
            // 
            // BtnLong_Click
            // 
            BtnLong_Click.BackColor = Color.Silver;
            BtnLong_Click.Dock = DockStyle.Fill;
            BtnLong_Click.Location = new Point(423, 3);
            BtnLong_Click.Name = "BtnLong_Click";
            BtnLong_Click.Size = new Size(134, 70);
            BtnLong_Click.TabIndex = 3;
            BtnLong_Click.Text = "Long";
            BtnLong_Click.UseVisualStyleBackColor = false;
            BtnLong_Click.Click += BtnLong_Click_Click;
            // 
            // BtnFloat_Click
            // 
            BtnFloat_Click.BackColor = Color.DarkGray;
            BtnFloat_Click.Dock = DockStyle.Fill;
            BtnFloat_Click.Location = new Point(3, 79);
            BtnFloat_Click.Name = "BtnFloat_Click";
            BtnFloat_Click.Size = new Size(134, 70);
            BtnFloat_Click.TabIndex = 4;
            BtnFloat_Click.Text = "Float";
            BtnFloat_Click.UseVisualStyleBackColor = false;
            BtnFloat_Click.Click += BtnFloat_Click_Click;
            // 
            // BtnDouble_Click
            // 
            BtnDouble_Click.BackColor = Color.DarkGray;
            BtnDouble_Click.Dock = DockStyle.Fill;
            BtnDouble_Click.Location = new Point(143, 79);
            BtnDouble_Click.Name = "BtnDouble_Click";
            BtnDouble_Click.Size = new Size(134, 70);
            BtnDouble_Click.TabIndex = 5;
            BtnDouble_Click.Text = "Double";
            BtnDouble_Click.UseVisualStyleBackColor = false;
            BtnDouble_Click.Click += BtnDouble_Click_Click;
            // 
            // BtnDecimal_Click
            // 
            BtnDecimal_Click.BackColor = Color.DarkGray;
            BtnDecimal_Click.Dock = DockStyle.Fill;
            BtnDecimal_Click.Location = new Point(283, 79);
            BtnDecimal_Click.Name = "BtnDecimal_Click";
            BtnDecimal_Click.Size = new Size(134, 70);
            BtnDecimal_Click.TabIndex = 6;
            BtnDecimal_Click.Text = "Decimal";
            BtnDecimal_Click.UseVisualStyleBackColor = false;
            BtnDecimal_Click.Click += BtnDecimal_Click_Click;
            // 
            // BtnPow_Click
            // 
            BtnPow_Click.BackColor = Color.Gray;
            BtnPow_Click.Dock = DockStyle.Fill;
            BtnPow_Click.Location = new Point(423, 79);
            BtnPow_Click.Name = "BtnPow_Click";
            BtnPow_Click.Size = new Size(134, 70);
            BtnPow_Click.TabIndex = 7;
            BtnPow_Click.Text = "POW";
            BtnPow_Click.UseVisualStyleBackColor = false;
            BtnPow_Click.Click += BtnPow_Click_Click;
            // 
            // BtnRound_Click
            // 
            BtnRound_Click.BackColor = Color.Gray;
            BtnRound_Click.Dock = DockStyle.Fill;
            BtnRound_Click.Location = new Point(3, 155);
            BtnRound_Click.Name = "BtnRound_Click";
            BtnRound_Click.Size = new Size(134, 70);
            BtnRound_Click.TabIndex = 8;
            BtnRound_Click.Text = "RND";
            BtnRound_Click.UseVisualStyleBackColor = false;
            BtnRound_Click.Click += BtnRound_Click_Click;
            // 
            // BtnSqrt_Click
            // 
            BtnSqrt_Click.BackColor = Color.Gray;
            BtnSqrt_Click.Dock = DockStyle.Fill;
            BtnSqrt_Click.Location = new Point(143, 155);
            BtnSqrt_Click.Name = "BtnSqrt_Click";
            BtnSqrt_Click.Size = new Size(134, 70);
            BtnSqrt_Click.TabIndex = 9;
            BtnSqrt_Click.Text = "SQRT";
            BtnSqrt_Click.UseVisualStyleBackColor = false;
            BtnSqrt_Click.Click += BtnSqrt_Click_Click;
            // 
            // BtnClear_Click
            // 
            BtnClear_Click.BackColor = Color.White;
            BtnClear_Click.Dock = DockStyle.Fill;
            BtnClear_Click.Location = new Point(283, 155);
            BtnClear_Click.Name = "BtnClear_Click";
            BtnClear_Click.Size = new Size(134, 70);
            BtnClear_Click.TabIndex = 10;
            BtnClear_Click.Text = "Clear";
            BtnClear_Click.UseVisualStyleBackColor = false;
            BtnClear_Click.Click += BtnClear_Click_Click;
            // 
            // BtnExit_Click
            // 
            BtnExit_Click.BackColor = Color.Black;
            BtnExit_Click.Dock = DockStyle.Fill;
            BtnExit_Click.ForeColor = Color.White;
            BtnExit_Click.Location = new Point(423, 155);
            BtnExit_Click.Name = "BtnExit_Click";
            BtnExit_Click.Size = new Size(134, 70);
            BtnExit_Click.TabIndex = 11;
            BtnExit_Click.Text = "Exit";
            BtnExit_Click.UseVisualStyleBackColor = false;
            BtnExit_Click.Click += BtnExit_Click_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = SystemColors.GradientActiveCaption;
            lblDisplay.Dock = DockStyle.Fill;
            lblDisplay.Location = new Point(3, 0);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(560, 78);
            lblDisplay.TabIndex = 1;
            lblDisplay.Text = "Click a Button";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmOfDataTypes
            // 
            BackColor = Color.FromArgb(192, 255, 192);
            CancelButton = BtnExit_Click;
            ClientSize = new Size(566, 390);
            Controls.Add(tableLayoutPanel1);
            Name = "frmOfDataTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 4 - Data Types";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            }

        private void BtnExit_Click_Click(object? sender, EventArgs e)
            {
            this.Close();
            }

        private void BtnClear_Click_Click(object? sender, EventArgs e)
            {
            lblDisplay.Text = "";
            }


        private void BtnSqrt_Click_Click(object? sender, EventArgs e)
            {
            double number = 16;
            double result = Math.Sqrt(number);
            lblDisplay.Text = $"The square root of {number} is {result}";
            }

        private void BtnRound_Click_Click(object? sender, EventArgs e)
            {
            double number = 5.6789123;
            int digits = 4;
            double result = Math.Round(number, digits);
            lblDisplay.Text = $"Rounding {number} to {digits} digits is {result}";
            }

        private void BtnPow_Click_Click(object? sender, EventArgs e)
            {
            double baseNumber = 2;
            double exponent = 3;
            double result = Math.Pow(baseNumber, exponent);
            lblDisplay.Text = $"The result of {baseNumber}^{exponent} is {result}";
            }

        private void BtnDecimal_Click_Click(object? sender, EventArgs e)
            {
            decimal leftOperand = 7.1234567890123456789012345m;
            decimal rightOperand = 2.0m;
            decimal result = leftOperand * rightOperand;
            lblDisplay.Text = $"{leftOperand} * {rightOperand} = {result}";
            }

        private void BtnDouble_Click_Click(object? sender, EventArgs e)
            {
            double leftOperand = 7.123456789012345;
            double rightOperand = 2.0;
            double result = leftOperand / rightOperand;
            lblDisplay.Text = $"{leftOperand} / {rightOperand} = {result:F15}";
            }

        private void BtnFloat_Click_Click(object? sender, EventArgs e)
            {
            float leftOperand = 7.1234567f;
            float rightOperand = 2.0f;
            float result = leftOperand % rightOperand;
            lblDisplay.Text = $"{leftOperand} % {rightOperand} = {result:F7}";
            }

        private void BtnLong_Click_Click(object? sender, EventArgs e)
            {
            long leftOperand = 15;
            long rightOperand = 4;
            long result = leftOperand % rightOperand;
            lblDisplay.Text = $"{leftOperand} % {rightOperand} = {result}";
            }

        private void BtnInt_Click_Click(object? sender, EventArgs e)
            {
            int leftOperand = 7;
            int rightOperand = 2;
            int result = leftOperand / rightOperand;
            lblDisplay.Text = $"{leftOperand} / {rightOperand} = {result}";
            }

        private void BtnShort_Click_Click(object? sender, EventArgs e)
            {
            short leftOperand = 10;
            short rightOperand = 5;
            short result = (short)(leftOperand - rightOperand);
            lblDisplay.Text = $"{leftOperand} - {rightOperand} = {result}";
            }

        private void BtnByte_Click_Click(object? sender, EventArgs e)
            {
            byte leftOperand = 2;
            byte rightOperand = 3;
            byte result = (byte)(leftOperand + rightOperand);
            lblDisplay.Text = $"{leftOperand} + {rightOperand} = {result}";
            }
        }
    }

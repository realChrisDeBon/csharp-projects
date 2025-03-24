namespace CheckDigitLab
{
    partial class frmCheckDigit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_exit = new Button();
            btn_reset = new Button();
            btn_process = new Button();
            txt_account_number = new TextBox();
            txt_account_confirm = new TextBox();
            txt_payment_amount = new TextBox();
            lbl_amount = new Label();
            label1 = new Label();
            mainLayout = new TableLayoutPanel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            midLayout = new TableLayoutPanel();
            formPanel = new Panel();
            btn_new_account_num = new Button();
            midBarPanel = new Panel();
            lbl_msg_to_user = new Label();
            logoPic = new PictureBox();
            panel1 = new Panel();
            lbl_name = new Label();
            notifyIcon1 = new NotifyIcon(components);
            mainLayout.SuspendLayout();
            midLayout.SuspendLayout();
            formPanel.SuspendLayout();
            midBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_exit.Location = new Point(444, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "&Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(64, 139);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 1;
            btn_reset.Text = "&Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_process
            // 
            btn_process.Location = new Point(3, 139);
            btn_process.Name = "btn_process";
            btn_process.Size = new Size(55, 23);
            btn_process.TabIndex = 2;
            btn_process.Text = "&Process";
            btn_process.UseVisualStyleBackColor = true;
            btn_process.Click += btn_process_Click;
            // 
            // txt_account_number
            // 
            txt_account_number.Location = new Point(3, 28);
            txt_account_number.Name = "txt_account_number";
            txt_account_number.PlaceholderText = "account number";
            txt_account_number.Size = new Size(228, 23);
            txt_account_number.TabIndex = 3;
            txt_account_number.TextChanged += txt_user_input_accountnumber_TextChanged;
            // 
            // txt_account_confirm
            // 
            txt_account_confirm.Location = new Point(3, 57);
            txt_account_confirm.Name = "txt_account_confirm";
            txt_account_confirm.PlaceholderText = "confirm account number";
            txt_account_confirm.Size = new Size(228, 23);
            txt_account_confirm.TabIndex = 4;
            txt_account_confirm.TextChanged += txt_user_input_accountnumber_TextChanged;
            // 
            // txt_payment_amount
            // 
            txt_payment_amount.Location = new Point(3, 110);
            txt_payment_amount.Name = "txt_payment_amount";
            txt_payment_amount.PlaceholderText = "$0.00";
            txt_payment_amount.Size = new Size(228, 23);
            txt_payment_amount.TabIndex = 5;
            txt_payment_amount.TextChanged += txt_user_input_moneyamount_TextChanged;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Location = new Point(3, 92);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(102, 15);
            lbl_amount.TabIndex = 6;
            lbl_amount.Text = "Payment amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 7;
            label1.Text = "Account number:";
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.RosyBrown;
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(panel4, 1, 2);
            mainLayout.Controls.Add(panel3, 0, 2);
            mainLayout.Controls.Add(panel2, 0, 1);
            mainLayout.Controls.Add(midLayout, 1, 1);
            mainLayout.Controls.Add(logoPic, 0, 0);
            mainLayout.Controls.Add(panel1, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            mainLayout.Size = new Size(622, 467);
            mainLayout.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RosyBrown;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(100, 392);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(522, 75);
            panel4.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 392);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 75);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 317);
            panel2.TabIndex = 12;
            // 
            // midLayout
            // 
            midLayout.ColumnCount = 1;
            midLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            midLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            midLayout.Controls.Add(formPanel, 0, 0);
            midLayout.Controls.Add(midBarPanel, 0, 1);
            midLayout.Dock = DockStyle.Fill;
            midLayout.Location = new Point(100, 75);
            midLayout.Margin = new Padding(0);
            midLayout.Name = "midLayout";
            midLayout.RowCount = 2;
            midLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            midLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            midLayout.Size = new Size(522, 317);
            midLayout.TabIndex = 9;
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.FromArgb(224, 224, 224);
            formPanel.Controls.Add(btn_new_account_num);
            formPanel.Controls.Add(btn_exit);
            formPanel.Controls.Add(btn_process);
            formPanel.Controls.Add(btn_reset);
            formPanel.Controls.Add(txt_payment_amount);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(txt_account_number);
            formPanel.Controls.Add(lbl_amount);
            formPanel.Controls.Add(txt_account_confirm);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(0, 0);
            formPanel.Margin = new Padding(0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(522, 253);
            formPanel.TabIndex = 9;
            // 
            // btn_new_account_num
            // 
            btn_new_account_num.Location = new Point(156, 139);
            btn_new_account_num.Name = "btn_new_account_num";
            btn_new_account_num.Size = new Size(75, 23);
            btn_new_account_num.TabIndex = 8;
            btn_new_account_num.Text = "New Acc";
            btn_new_account_num.UseVisualStyleBackColor = true;
            btn_new_account_num.Click += btn_new_account_num_Click;
            // 
            // midBarPanel
            // 
            midBarPanel.BackColor = Color.Linen;
            midBarPanel.Controls.Add(lbl_msg_to_user);
            midBarPanel.Dock = DockStyle.Fill;
            midBarPanel.Location = new Point(0, 253);
            midBarPanel.Margin = new Padding(0);
            midBarPanel.Name = "midBarPanel";
            midBarPanel.Size = new Size(522, 64);
            midBarPanel.TabIndex = 10;
            // 
            // lbl_msg_to_user
            // 
            lbl_msg_to_user.Dock = DockStyle.Fill;
            lbl_msg_to_user.Location = new Point(0, 0);
            lbl_msg_to_user.Name = "lbl_msg_to_user";
            lbl_msg_to_user.Size = new Size(522, 64);
            lbl_msg_to_user.TabIndex = 0;
            lbl_msg_to_user.Text = "     ";
            // 
            // logoPic
            // 
            logoPic.BackColor = Color.RosyBrown;
            logoPic.Image = Properties.Resources.bank_logo_generic_5_1539765627;
            logoPic.Location = new Point(0, 0);
            logoPic.Margin = new Padding(0);
            logoPic.Name = "logoPic";
            logoPic.Size = new Size(80, 74);
            logoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPic.TabIndex = 10;
            logoPic.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(lbl_name);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(100, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 75);
            panel1.TabIndex = 11;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Old English Text MT", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(6, 9);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(321, 38);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Global Finance Corp.";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "test";
            notifyIcon1.BalloonTipTitle = "tes";
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // frmCheckDigit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 467);
            Controls.Add(mainLayout);
            MinimumSize = new Size(480, 410);
            Name = "frmCheckDigit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Digit Verification";
            mainLayout.ResumeLayout(false);
            midLayout.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            midBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btn_new_account_num_Click(object sender, EventArgs e)
        {
            string accnumber = AccountVerification.GenerateValidAccountNumber();
            txt_account_number.Text = accnumber;
            notifyIcon1.BalloonTipText = "New account number generated.";
            notifyIcon1.BalloonTipTitle = "New Account Number";
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            string accountNumber = txt_account_number.Text;
            string confirmAccountNumber = txt_account_confirm.Text;
            string paymentAmount = txt_payment_amount.Text;

            if (!AccountVerification.ValidateAccountNumber(accountNumber, confirmAccountNumber, out string accountErrorMessage))
            {
                lbl_msg_to_user.Text = accountErrorMessage;
                return;
            }

            if (!AccountVerification.ValidatePaymentAmount(paymentAmount, out string paymentErrorMessage))
            {
                lbl_msg_to_user.Text = paymentErrorMessage;
                return;
            }

            // Remove the $ symbol if present
            if (paymentAmount.StartsWith("$"))
            {
                paymentAmount = paymentAmount.Substring(1);
            }

            decimal payment = decimal.Parse(paymentAmount);
            string formattedPayment = payment.ToString("C");

            DateTime currentDate = DateTime.Now;
            string message = $"A payment of {formattedPayment} was applied to account {accountNumber} on {currentDate:MMMM dd, yyyy}.";
            lbl_msg_to_user.Text = message;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_account_number.Clear();
            txt_account_confirm.Clear();
            txt_payment_amount.Clear();
            lbl_msg_to_user.Text = string.Empty;
        }

        private void txt_user_input_moneyamount_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Filter out invalid characters but allow one negative sign at the beginning
            string filtered = new string(
                textBox.Text.Where((c, i) => char.IsDigit(c) || (textBox.Text.Count(ch => ch == '.') < 2 && c == '.') || (c == '$' && i == 0)).ToArray()
            );

            // If filtered text differs, replace the text and fix cursor position
            if (filtered != textBox.Text)
            {
                int oldPos = textBox.SelectionStart - (textBox.Text.Length - filtered.Length);
                textBox.Text = filtered;
                textBox.SelectionStart = Math.Max(oldPos, 0);
            }
        }

        private void txt_user_input_accountnumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Filter out invalid characters but allow one negative sign at the beginning
            string filtered = new string(
                textBox.Text.Where((c, i) => char.IsDigit(c)).ToArray()
            );

            // If filtered text differs, replace the text and fix cursor position
            if (filtered != textBox.Text)
            {
                int oldPos = textBox.SelectionStart - (textBox.Text.Length - filtered.Length);
                textBox.Text = filtered;
                textBox.SelectionStart = Math.Max(oldPos, 0);
            }
        }

        #endregion

        private Button btn_exit;
        private Button btn_reset;
        private Button btn_process;
        public TextBox txt_account_number;
        public TextBox txt_account_confirm;
        public TextBox txt_payment_amount;
        private Label lbl_amount;
        private Label label1;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel midLayout;
        private Panel formPanel;
        private Panel midBarPanel;
        private PictureBox logoPic;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label lbl_name;
        private Label lbl_msg_to_user;
        private Button btn_new_account_num;
        private NotifyIcon notifyIcon1;
    }
}

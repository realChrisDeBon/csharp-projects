namespace OperationsProject
{
    partial class mainForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            input_one = new TextBox();
            input_two = new TextBox();
            btn_clear = new Button();
            btn_exit = new Button();
            result_output = new Label();
            fibonacci_show = new Button();
            fibonacci_do = new Button();
            factorial_do = new Button();
            factorial_show = new Button();
            modulus_show = new Button();
            modulus_do = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.Controls.Add(modulus_show, 1, 0);
            tableLayoutPanel1.Controls.Add(factorial_show, 3, 0);
            tableLayoutPanel1.Controls.Add(fibonacci_show, 5, 0);
            tableLayoutPanel1.Controls.Add(modulus_do, 1, 1);
            tableLayoutPanel1.Controls.Add(fibonacci_do, 5, 1);
            tableLayoutPanel1.Controls.Add(factorial_do, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(480, 111);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(result_output, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 237);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 31.2499981F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(480, 113);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btn_clear, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_exit, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 73);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(474, 37);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(input_two, 0, 1);
            tableLayoutPanel4.Controls.Add(input_one, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(480, 111);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(486, 353);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // input_one
            // 
            input_one.Dock = DockStyle.Fill;
            input_one.Location = new Point(3, 3);
            input_one.Name = "input_one";
            input_one.Size = new Size(474, 23);
            input_one.TabIndex = 1;
            // 
            // input_two
            // 
            input_two.Dock = DockStyle.Fill;
            input_two.Location = new Point(3, 58);
            input_two.Name = "input_two";
            input_two.Size = new Size(474, 23);
            input_two.TabIndex = 2;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(64, 64, 64);
            btn_clear.Dock = DockStyle.Fill;
            btn_clear.FlatStyle = FlatStyle.Popup;
            btn_clear.Font = new Font("Courier New", 14.25F);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(3, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(231, 31);
            btn_clear.TabIndex = 0;
            btn_clear.Text = "&Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(64, 64, 64);
            btn_exit.Dock = DockStyle.Fill;
            btn_exit.FlatStyle = FlatStyle.Popup;
            btn_exit.Font = new Font("Courier New", 14.25F);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(240, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(231, 31);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "&Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += exitbtn_click;
            // 
            // result_output
            // 
            result_output.AutoSize = true;
            result_output.BackColor = Color.FromArgb(192, 255, 255);
            result_output.Dock = DockStyle.Fill;
            result_output.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result_output.ForeColor = Color.Black;
            result_output.Location = new Point(3, 35);
            result_output.Name = "result_output";
            result_output.Size = new Size(474, 35);
            result_output.TabIndex = 2;
            // 
            // fibonacci_show
            // 
            fibonacci_show.BackColor = Color.FromArgb(64, 0, 0);
            fibonacci_show.Dock = DockStyle.Fill;
            fibonacci_show.FlatStyle = FlatStyle.Popup;
            fibonacci_show.Font = new Font("Courier New", 14.25F);
            fibonacci_show.ForeColor = Color.White;
            fibonacci_show.Location = new Point(324, 3);
            fibonacci_show.Name = "fibonacci_show";
            fibonacci_show.Size = new Size(147, 49);
            fibonacci_show.TabIndex = 2;
            fibonacci_show.Text = "Fibonacci";
            fibonacci_show.UseVisualStyleBackColor = false;
            // 
            // fibonacci_do
            // 
            fibonacci_do.BackColor = Color.FromArgb(64, 0, 0);
            fibonacci_do.Dock = DockStyle.Fill;
            fibonacci_do.FlatStyle = FlatStyle.Popup;
            fibonacci_do.Font = new Font("Courier New", 14.25F);
            fibonacci_do.ForeColor = Color.White;
            fibonacci_do.Location = new Point(324, 58);
            fibonacci_do.Name = "fibonacci_do";
            fibonacci_do.Size = new Size(147, 50);
            fibonacci_do.TabIndex = 5;
            fibonacci_do.Text = "(^)";
            fibonacci_do.UseVisualStyleBackColor = false;
            // 
            // factorial_do
            // 
            factorial_do.BackColor = Color.FromArgb(64, 0, 0);
            factorial_do.Dock = DockStyle.Fill;
            factorial_do.FlatStyle = FlatStyle.Popup;
            factorial_do.Font = new Font("Courier New", 14.25F);
            factorial_do.ForeColor = Color.White;
            factorial_do.Location = new Point(166, 58);
            factorial_do.Name = "factorial_do";
            factorial_do.Size = new Size(147, 50);
            factorial_do.TabIndex = 4;
            factorial_do.Text = "!";
            factorial_do.UseVisualStyleBackColor = false;
            // 
            // factorial_show
            // 
            factorial_show.BackColor = Color.FromArgb(64, 0, 0);
            factorial_show.Dock = DockStyle.Fill;
            factorial_show.FlatStyle = FlatStyle.Popup;
            factorial_show.Font = new Font("Courier New", 14.25F);
            factorial_show.ForeColor = Color.White;
            factorial_show.Location = new Point(166, 3);
            factorial_show.Name = "factorial_show";
            factorial_show.Size = new Size(147, 49);
            factorial_show.TabIndex = 1;
            factorial_show.Text = "Factorial";
            factorial_show.UseVisualStyleBackColor = false;
            // 
            // modulus_show
            // 
            modulus_show.BackColor = Color.FromArgb(64, 0, 0);
            modulus_show.Dock = DockStyle.Fill;
            modulus_show.FlatStyle = FlatStyle.Popup;
            modulus_show.Font = new Font("Courier New", 14.25F);
            modulus_show.ForeColor = Color.White;
            modulus_show.Location = new Point(8, 3);
            modulus_show.Name = "modulus_show";
            modulus_show.Size = new Size(147, 49);
            modulus_show.TabIndex = 0;
            modulus_show.Text = "Modulus";
            modulus_show.UseVisualStyleBackColor = false;
            // 
            // modulus_do
            // 
            modulus_do.BackColor = Color.FromArgb(64, 0, 0);
            modulus_do.Dock = DockStyle.Fill;
            modulus_do.FlatStyle = FlatStyle.Popup;
            modulus_do.Font = new Font("Courier New", 14.25F);
            modulus_do.ForeColor = Color.White;
            modulus_do.Location = new Point(8, 58);
            modulus_do.Name = "modulus_do";
            modulus_do.Size = new Size(147, 50);
            modulus_do.TabIndex = 3;
            modulus_do.Text = "%";
            modulus_do.UseVisualStyleBackColor = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(486, 353);
            Controls.Add(tableLayoutPanel5);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operations Chris DeBon";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button modulus_show;
        private Button factorial_show;
        private Button fibonacci_show;
        private Button modulus_do;
        private Button fibonacci_do;
        private Button factorial_do;
        private Button btn_clear;
        private Button btn_exit;
        private Label result_output;
        private TextBox input_two;
        private TextBox input_one;
    }
}

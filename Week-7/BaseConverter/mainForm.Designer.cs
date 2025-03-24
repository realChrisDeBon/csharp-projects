
using System.Reflection.Metadata;

namespace BaseConverter
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
            baseLayout = new TableLayoutPanel();
            conversionBtnsLayout = new TableLayoutPanel();
            btn_basenine = new Button();
            btn_basesix = new Button();
            btn_octal = new Button();
            btn_hex = new Button();
            btn_binary = new Button();
            btn_process = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_exit = new Button();
            btn_clear = new Button();
            targetNumBaseOfSplitter = new TableLayoutPanel();
            conversionInputLayout = new TableLayoutPanel();
            lbl_instruct_input = new Label();
            txt_input = new TextBox();
            txt_baseof = new TextBox();
            lbl_result = new Label();
            baseLayout.SuspendLayout();
            conversionBtnsLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            targetNumBaseOfSplitter.SuspendLayout();
            conversionInputLayout.SuspendLayout();
            SuspendLayout();
            // 
            // baseLayout
            // 
            baseLayout.ColumnCount = 1;
            baseLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            baseLayout.Controls.Add(conversionBtnsLayout, 0, 5);
            baseLayout.Controls.Add(tableLayoutPanel2, 0, 7);
            baseLayout.Controls.Add(targetNumBaseOfSplitter, 0, 3);
            baseLayout.Controls.Add(lbl_result, 0, 0);
            baseLayout.Dock = DockStyle.Fill;
            baseLayout.Location = new Point(0, 0);
            baseLayout.Name = "baseLayout";
            baseLayout.RowCount = 9;
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            baseLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            baseLayout.Size = new Size(670, 476);
            baseLayout.TabIndex = 0;
            // 
            // conversionBtnsLayout
            // 
            conversionBtnsLayout.ColumnCount = 7;
            conversionBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            conversionBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            conversionBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            conversionBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            conversionBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            conversionBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            conversionBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            conversionBtnsLayout.Controls.Add(btn_basenine, 3, 2);
            conversionBtnsLayout.Controls.Add(btn_basesix, 1, 2);
            conversionBtnsLayout.Controls.Add(btn_octal, 5, 0);
            conversionBtnsLayout.Controls.Add(btn_hex, 3, 0);
            conversionBtnsLayout.Controls.Add(btn_binary, 1, 0);
            conversionBtnsLayout.Controls.Add(btn_process, 5, 2);
            conversionBtnsLayout.Dock = DockStyle.Fill;
            conversionBtnsLayout.Location = new Point(3, 223);
            conversionBtnsLayout.Name = "conversionBtnsLayout";
            conversionBtnsLayout.RowCount = 3;
            conversionBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            conversionBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            conversionBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            conversionBtnsLayout.Size = new Size(664, 74);
            conversionBtnsLayout.TabIndex = 0;
            // 
            // btn_basenine
            // 
            btn_basenine.Dock = DockStyle.Fill;
            btn_basenine.FlatAppearance.BorderColor = Color.Black;
            btn_basenine.FlatStyle = FlatStyle.Popup;
            btn_basenine.Font = new Font("Lucida Console", 14.25F);
            btn_basenine.ForeColor = Color.White;
            btn_basenine.Location = new Point(227, 41);
            btn_basenine.Name = "btn_basenine";
            btn_basenine.Size = new Size(208, 30);
            btn_basenine.TabIndex = 2;
            btn_basenine.Tag = "9";
            btn_basenine.Text = "Base &9";
            btn_basenine.UseVisualStyleBackColor = true;
            btn_basenine.Click += btn_conversion_Click;
            // 
            // btn_basesix
            // 
            btn_basesix.Dock = DockStyle.Fill;
            btn_basesix.FlatAppearance.BorderColor = Color.Black;
            btn_basesix.FlatStyle = FlatStyle.Popup;
            btn_basesix.Font = new Font("Lucida Console", 14.25F);
            btn_basesix.ForeColor = Color.White;
            btn_basesix.Location = new Point(8, 41);
            btn_basesix.Name = "btn_basesix";
            btn_basesix.Size = new Size(208, 30);
            btn_basesix.TabIndex = 2;
            btn_basesix.Tag = "6";
            btn_basesix.Text = "Base &6";
            btn_basesix.UseVisualStyleBackColor = true;
            btn_basesix.Click += btn_conversion_Click;
            // 
            // btn_octal
            // 
            btn_octal.Dock = DockStyle.Fill;
            btn_octal.FlatAppearance.BorderColor = Color.Black;
            btn_octal.FlatAppearance.BorderSize = 2;
            btn_octal.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_octal.FlatStyle = FlatStyle.Popup;
            btn_octal.Font = new Font("Lucida Console", 14.25F);
            btn_octal.ForeColor = Color.White;
            btn_octal.Location = new Point(446, 3);
            btn_octal.Name = "btn_octal";
            btn_octal.Size = new Size(208, 29);
            btn_octal.TabIndex = 2;
            btn_octal.Tag = "8";
            btn_octal.Text = "&Octal";
            btn_octal.UseVisualStyleBackColor = true;
            btn_octal.Click += btn_conversion_Click;
            // 
            // btn_hex
            // 
            btn_hex.Dock = DockStyle.Fill;
            btn_hex.FlatAppearance.BorderColor = Color.Black;
            btn_hex.FlatAppearance.BorderSize = 2;
            btn_hex.FlatStyle = FlatStyle.Popup;
            btn_hex.Font = new Font("Lucida Console", 14.25F);
            btn_hex.ForeColor = Color.White;
            btn_hex.Location = new Point(227, 3);
            btn_hex.Name = "btn_hex";
            btn_hex.Size = new Size(208, 29);
            btn_hex.TabIndex = 2;
            btn_hex.Tag = "16";
            btn_hex.Text = "&Hex";
            btn_hex.UseVisualStyleBackColor = true;
            btn_hex.Click += btn_conversion_Click;
            // 
            // btn_binary
            // 
            btn_binary.Dock = DockStyle.Fill;
            btn_binary.FlatStyle = FlatStyle.Popup;
            btn_binary.Font = new Font("Lucida Console", 14.25F);
            btn_binary.ForeColor = Color.White;
            btn_binary.Location = new Point(8, 3);
            btn_binary.Name = "btn_binary";
            btn_binary.Size = new Size(208, 29);
            btn_binary.TabIndex = 1;
            btn_binary.Tag = "2";
            btn_binary.Text = "&Binary";
            btn_binary.UseVisualStyleBackColor = true;
            btn_binary.Click += btn_conversion_Click;
            // 
            // btn_process
            // 
            btn_process.Dock = DockStyle.Fill;
            btn_process.FlatAppearance.BorderColor = Color.Black;
            btn_process.FlatStyle = FlatStyle.Popup;
            btn_process.Font = new Font("Lucida Console", 14.25F);
            btn_process.ForeColor = Color.White;
            btn_process.Location = new Point(446, 41);
            btn_process.Name = "btn_process";
            btn_process.Size = new Size(208, 30);
            btn_process.TabIndex = 3;
            btn_process.Text = "&Process";
            btn_process.UseVisualStyleBackColor = true;
            btn_process.Click += btn_process_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btn_exit, 3, 0);
            tableLayoutPanel2.Controls.Add(btn_clear, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 308);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(664, 34);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // btn_exit
            // 
            btn_exit.Dock = DockStyle.Fill;
            btn_exit.FlatAppearance.BorderColor = Color.Black;
            btn_exit.FlatStyle = FlatStyle.Popup;
            btn_exit.Font = new Font("Lucida Console", 14.25F);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(345, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(296, 28);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "&Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Fill;
            btn_clear.FlatAppearance.BorderColor = Color.Black;
            btn_clear.FlatStyle = FlatStyle.Popup;
            btn_clear.Font = new Font("Lucida Console", 14.25F);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(23, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(296, 28);
            btn_clear.TabIndex = 6;
            btn_clear.Text = "&Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // targetNumBaseOfSplitter
            // 
            targetNumBaseOfSplitter.ColumnCount = 2;
            targetNumBaseOfSplitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            targetNumBaseOfSplitter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            targetNumBaseOfSplitter.Controls.Add(conversionInputLayout, 0, 0);
            targetNumBaseOfSplitter.Controls.Add(txt_baseof, 1, 0);
            targetNumBaseOfSplitter.Dock = DockStyle.Fill;
            targetNumBaseOfSplitter.Location = new Point(0, 165);
            targetNumBaseOfSplitter.Margin = new Padding(0);
            targetNumBaseOfSplitter.Name = "targetNumBaseOfSplitter";
            targetNumBaseOfSplitter.RowCount = 1;
            targetNumBaseOfSplitter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            targetNumBaseOfSplitter.Size = new Size(670, 50);
            targetNumBaseOfSplitter.TabIndex = 6;
            // 
            // conversionInputLayout
            // 
            conversionInputLayout.ColumnCount = 1;
            conversionInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            conversionInputLayout.Controls.Add(lbl_instruct_input, 0, 0);
            conversionInputLayout.Controls.Add(txt_input, 0, 1);
            conversionInputLayout.Dock = DockStyle.Fill;
            conversionInputLayout.Location = new Point(3, 3);
            conversionInputLayout.Name = "conversionInputLayout";
            conversionInputLayout.RowCount = 2;
            conversionInputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            conversionInputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            conversionInputLayout.Size = new Size(544, 44);
            conversionInputLayout.TabIndex = 4;
            // 
            // lbl_instruct_input
            // 
            lbl_instruct_input.AutoSize = true;
            lbl_instruct_input.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_instruct_input.ForeColor = Color.White;
            lbl_instruct_input.Location = new Point(3, 0);
            lbl_instruct_input.Name = "lbl_instruct_input";
            lbl_instruct_input.Size = new Size(152, 15);
            lbl_instruct_input.TabIndex = 1;
            lbl_instruct_input.Text = "Number to convert:";
            lbl_instruct_input.Click += lbl_instruct_input_Click;
            // 
            // txt_input
            // 
            txt_input.Dock = DockStyle.Fill;
            txt_input.Location = new Point(3, 18);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(538, 23);
            txt_input.TabIndex = 3;
            txt_input.TextChanged += NumericOrDecimalOnly_TextChanged;
            // 
            // txt_baseof
            // 
            txt_baseof.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_baseof.Location = new Point(553, 21);
            txt_baseof.Margin = new Padding(3, 3, 3, 6);
            txt_baseof.MaxLength = 2;
            txt_baseof.Name = "txt_baseof";
            txt_baseof.PlaceholderText = "... base of ";
            txt_baseof.RightToLeft = RightToLeft.Yes;
            txt_baseof.Size = new Size(114, 23);
            txt_baseof.TabIndex = 3;
            txt_baseof.TextChanged += NumericOrDecimalOnly_TextChanged;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Dock = DockStyle.Fill;
            lbl_result.Font = new Font("Lucida Console", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_result.ForeColor = Color.White;
            lbl_result.Location = new Point(5, 5);
            lbl_result.Margin = new Padding(5);
            lbl_result.Name = "lbl_result";
            lbl_result.RightToLeft = RightToLeft.Yes;
            lbl_result.Size = new Size(660, 120);
            lbl_result.TabIndex = 2;
            lbl_result.Text = "0";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(670, 476);
            Controls.Add(baseLayout);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseConverter";
            KeyPress += MainForm_KeyPress;
            baseLayout.ResumeLayout(false);
            baseLayout.PerformLayout();
            conversionBtnsLayout.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            targetNumBaseOfSplitter.ResumeLayout(false);
            targetNumBaseOfSplitter.PerformLayout();
            conversionInputLayout.ResumeLayout(false);
            conversionInputLayout.PerformLayout();
            ResumeLayout(false);
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
                switch (e.KeyChar)
                {
                    case (char)Keys.Escape:
                        Application.Exit();
                        break;
                }
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            try
            {
                bool goodBase = IsValidBase(txt_baseof.Text);
                if(goodBase == true)
                {
                    ConvertToBase(targetNumber, targetBase);
                } else
                {
                    MessageBox.Show("Invalid base. Please enter a number between 2 and 16.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetBase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_conversion_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                if (button == null)
                    return;

                int targetBase = int.Parse(button.Tag.ToString());

                ConvertToBase(targetNumber, targetBase);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void NumericOrDecimalOnly_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Filter out invalid characters
            string filtered = new string(
                textBox.Text.Where(c => char.IsDigit(c)).ToArray()
            );

            // If filtered text differs, replace the text and fix cursor position
            if (filtered != textBox.Text)
            {
                int oldPos = textBox.SelectionStart - (textBox.Text.Length - filtered.Length);
                textBox.Text = filtered;
                textBox.SelectionStart = Math.Max(oldPos, 0);
            }
        }

        private TableLayoutPanel baseLayout;
        private TableLayoutPanel conversionBtnsLayout;
        private Button btn_hex;
        private Button btn_binary;
        private Button btn_basenine;
        private Button btn_basesix;
        private Button btn_octal;
        private Label lbl_instruct_input;
        public Label lbl_result;
        private TextBox txt_input;
        private TableLayoutPanel conversionInputLayout;
        public TextBox txt_baseof;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_exit;
        private Button btn_clear;
        private TableLayoutPanel targetNumBaseOfSplitter;
        private Button btn_process;
    }
}

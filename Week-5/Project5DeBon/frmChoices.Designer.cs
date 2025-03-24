
namespace Project5DeBon
{
    partial class frmChoices
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

        public static int lnum { get; set; } = 0;
        public static int rnum { get; set; } = 0;
        public static int checknum { get; set; }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            tableLayoutPanel1 = new TableLayoutPanel();
            RNum_lbl = new Label();
            LNum_lbl = new Label();
            rnum_txt = new TextBox();
            lnum_txt = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            message_lbl = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            numberToCheck_txt = new TextBox();
            instructions_lbl = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            NumToCheck_lbl = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            clear_btn = new Button();
            check_btn = new Button();
            exit_btn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.Controls.Add(RNum_lbl, 2, 0);
            tableLayoutPanel1.Controls.Add(LNum_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(rnum_txt, 2, 1);
            tableLayoutPanel1.Controls.Add(lnum_txt, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(794, 75);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // RNum_lbl
            // 
            RNum_lbl.AutoSize = true;
            RNum_lbl.Dock = DockStyle.Fill;
            RNum_lbl.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RNum_lbl.Location = new Point(443, 0);
            RNum_lbl.Name = "RNum_lbl";
            RNum_lbl.Size = new Size(348, 37);
            RNum_lbl.TabIndex = 0;
            RNum_lbl.Text = "Right Number";
            RNum_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LNum_lbl
            // 
            LNum_lbl.AutoSize = true;
            LNum_lbl.Dock = DockStyle.Fill;
            LNum_lbl.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNum_lbl.Location = new Point(3, 0);
            LNum_lbl.Name = "LNum_lbl";
            LNum_lbl.Size = new Size(346, 37);
            LNum_lbl.TabIndex = 1;
            LNum_lbl.Text = "Left Number";
            LNum_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rnum_txt
            // 
            rnum_txt.Dock = DockStyle.Top;
            rnum_txt.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rnum_txt.Location = new Point(443, 40);
            rnum_txt.Name = "rnum_txt";
            rnum_txt.PlaceholderText = "1000";
            rnum_txt.Size = new Size(348, 29);
            rnum_txt.TabIndex = 2;
            rnum_txt.TabStop = false;
            rnum_txt.TextChanged += rnum_txt_TextChanged;
            rnum_txt.KeyPress += rmum_txt_KeyPress;
            // 
            // lnum_txt
            // 
            lnum_txt.Dock = DockStyle.Top;
            lnum_txt.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnum_txt.Location = new Point(3, 40);
            lnum_txt.Name = "lnum_txt";
            lnum_txt.PlaceholderText = "-1000";
            lnum_txt.Size = new Size(346, 29);
            lnum_txt.TabIndex = 3;
            lnum_txt.TabStop = false;
            lnum_txt.TextChanged += lnum_txt_TextChanged;
            lnum_txt.KeyPress += lmum_txt_KeyPress;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(instructions_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel6.Controls.Add(message_lbl, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 244);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(794, 39);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // message_lbl
            // 
            message_lbl.Dock = DockStyle.Top;
            message_lbl.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message_lbl.Location = new Point(10, 0);
            message_lbl.Name = "message_lbl";
            message_lbl.Size = new Size(772, 34);
            message_lbl.TabIndex = 2;
            message_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.945F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.11F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.945F));
            tableLayoutPanel4.Controls.Add(numberToCheck_txt, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 164);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(794, 34);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // numberToCheck_txt
            // 
            numberToCheck_txt.Dock = DockStyle.Top;
            numberToCheck_txt.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberToCheck_txt.Location = new Point(224, 3);
            numberToCheck_txt.Name = "numberToCheck_txt";
            numberToCheck_txt.Size = new Size(344, 29);
            numberToCheck_txt.TabIndex = 5;
            numberToCheck_txt.TabStop = false;
            // 
            // instructions_lbl
            // 
            instructions_lbl.Dock = DockStyle.Fill;
            instructions_lbl.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructions_lbl.Location = new Point(3, 0);
            instructions_lbl.Name = "instructions_lbl";
            instructions_lbl.Size = new Size(794, 40);
            instructions_lbl.TabIndex = 1;
            instructions_lbl.Text = resources.GetString("instructions_lbl.Text");
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.945F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.11F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.945F));
            tableLayoutPanel3.Controls.Add(NumToCheck_lbl, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 124);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(794, 34);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // NumToCheck_lbl
            // 
            NumToCheck_lbl.Dock = DockStyle.Top;
            NumToCheck_lbl.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumToCheck_lbl.Location = new Point(224, 0);
            NumToCheck_lbl.Name = "NumToCheck_lbl";
            NumToCheck_lbl.Size = new Size(344, 34);
            NumToCheck_lbl.TabIndex = 2;
            NumToCheck_lbl.Text = "Number to be Checked";
            NumToCheck_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 7;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.56803F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2875509F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.000643F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2875509F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.000643F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2875509F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.56803F));
            tableLayoutPanel5.Controls.Add(clear_btn, 1, 0);
            tableLayoutPanel5.Controls.Add(check_btn, 3, 0);
            tableLayoutPanel5.Controls.Add(exit_btn, 5, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 204);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(794, 34);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // clear_btn
            // 
            clear_btn.Dock = DockStyle.Fill;
            clear_btn.Location = new Point(190, 3);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(107, 28);
            clear_btn.TabIndex = 0;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // check_btn
            // 
            check_btn.Dock = DockStyle.Fill;
            check_btn.Location = new Point(342, 3);
            check_btn.Name = "check_btn";
            check_btn.Size = new Size(107, 28);
            check_btn.TabIndex = 1;
            check_btn.Text = "Check";
            check_btn.UseVisualStyleBackColor = true;
            check_btn.Click += check_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Dock = DockStyle.Fill;
            exit_btn.Location = new Point(494, 3);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(107, 28);
            exit_btn.TabIndex = 2;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // frmChoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            CancelButton = exit_btn;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "frmChoices";
            Text = "DeBon Choices";
            KeyPress += frmChoices_KeyPress;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
            }

        private void frmChoices_KeyPress(object sender, KeyPressEventArgs e)
            {
            switch(e.KeyChar)
                {
                case (char)Keys.Enter:
                    check_btn.PerformClick();
                    break;
                case (char)Keys.Escape:
                    exit_btn.PerformClick();
                    break;
                case(char)Keys.C:
                    clear_btn.PerformClick();
                    break;
                }
            }

        private void lmum_txt_KeyPress(object sender, KeyPressEventArgs e)
            {
            try
                {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '-'))
                    {
                    e.Handled = true;
                    }
                }
            catch
                {
                // ignore
                }
            }

        private void lnum_txt_TextChanged(object sender, EventArgs e)
            {
            Int32.TryParse(lnum_txt.Text, out int _num);
            lnum = _num;
            }

        private void rmum_txt_KeyPress(object sender, KeyPressEventArgs e)
            {
            try
                {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                    {
                    e.Handled = true;
                    }
                }
            catch
                {
                // ignore
                }
            }

        private void rnum_txt_TextChanged(object sender, EventArgs e)
            {
            Int32.TryParse(rnum_txt.Text, out int _num);
            rnum = _num;
            }

        private void check_btn_Click(object sender, EventArgs e)
            {
            GetResponse();
            }

        private void GetResponse()
            {
            if(string.IsNullOrEmpty(lnum_txt.Text) || string.IsNullOrEmpty(rnum_txt.Text) || string.IsNullOrEmpty(numberToCheck_txt.Text))
                {
                message_lbl.Text = "Please enter a number in all fields.";
                numberToCheck_txt.Focus();
                return;
                }

            if(lnum >= rnum)
                {
                message_lbl.Text = "The lower end range number must be lesser than the high range number.";
                lnum_txt.Focus();
                return;
                }

            Int32.TryParse(numberToCheck_txt.Text, out int checknum);

            string returnString = $"{checknum} ";

            if ((checknum == lnum) || (checknum == rnum))
                {
                returnString += "is equal to ";
                returnString += checknum == lnum ? "the lower range." : "the higher range.";

                }
            else if (checknum < lnum)
                {
                returnString += "is below the low end of the range.";
                }
            else if (checknum > rnum)
                {
                returnString += "is above the high end of the range.";
                }
            else
                {
                returnString += "is within the range of the low end and high end range.";
                }

            message_lbl.Text = returnString;
            numberToCheck_txt.Focus();
            }

        private void exit_btn_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        // wipe everything clean
        private void clear_btn_Click(object sender, EventArgs e)
            {
            message_lbl.Text = String.Empty;
            numberToCheck_txt.Text = String.Empty;
            lnum_txt.Text = String.Empty;
            rnum_txt.Text = String.Empty;
            }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label instructions_lbl;
        private Label RNum_lbl;
        private Label LNum_lbl;
        private TextBox rnum_txt;
        private TextBox lnum_txt;
        private TableLayoutPanel tableLayoutPanel3;
        private Label NumToCheck_lbl;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox numberToCheck_txt;
        private TableLayoutPanel tableLayoutPanel5;
        private Button clear_btn;
        private Button check_btn;
        private Button exit_btn;
        private TableLayoutPanel tableLayoutPanel6;
        private Label message_lbl;
        }
}

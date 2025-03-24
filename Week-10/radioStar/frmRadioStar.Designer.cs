
namespace radioStar
{
    partial class frmRadioStar
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
            btnExit = new Button();
            btnReset = new Button();
            leftOperandTxt = new TextBox();
            rightOperandTxt = new TextBox();
            leftOpLbl = new Label();
            rightOpLbl = new Label();
            btnCalculate = new Button();
            msgOutLbl = new Label();
            groupRadioBtns = new GroupBox();
            optionModulus = new RadioButton();
            optionDivide = new RadioButton();
            optionMultiply = new RadioButton();
            optionSubtract = new RadioButton();
            optionAdd = new RadioButton();
            groupOptionControls = new GroupBox();
            optionVerbosity = new CheckBox();
            errorTooltip = new ToolTip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupRadioBtns.SuspendLayout();
            groupOptionControls.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Fill;
            btnExit.Location = new Point(363, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(174, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Fill;
            btnReset.Location = new Point(3, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(174, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // leftOperandTxt
            // 
            leftOperandTxt.Location = new Point(3, 20);
            leftOperandTxt.Name = "leftOperandTxt";
            leftOperandTxt.Size = new Size(258, 23);
            leftOperandTxt.TabIndex = 2;
            leftOperandTxt.TextChanged += txt_user_input_TextChanged;
            // 
            // rightOperandTxt
            // 
            rightOperandTxt.Location = new Point(3, 67);
            rightOperandTxt.Name = "rightOperandTxt";
            rightOperandTxt.Size = new Size(258, 23);
            rightOperandTxt.TabIndex = 3;
            rightOperandTxt.TextChanged += txt_user_input_TextChanged;
            // 
            // leftOpLbl
            // 
            leftOpLbl.AutoSize = true;
            leftOpLbl.Location = new Point(3, 0);
            leftOpLbl.Name = "leftOpLbl";
            leftOpLbl.Size = new Size(63, 15);
            leftOpLbl.TabIndex = 4;
            leftOpLbl.Text = "First value:";
            // 
            // rightOpLbl
            // 
            rightOpLbl.AutoSize = true;
            rightOpLbl.Location = new Point(3, 47);
            rightOpLbl.Name = "rightOpLbl";
            rightOpLbl.Size = new Size(80, 15);
            rightOpLbl.TabIndex = 5;
            rightOpLbl.Text = "Second value:";
            // 
            // btnCalculate
            // 
            btnCalculate.Dock = DockStyle.Fill;
            btnCalculate.Location = new Point(183, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(174, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // msgOutLbl
            // 
            msgOutLbl.BackColor = Color.Silver;
            msgOutLbl.BorderStyle = BorderStyle.Fixed3D;
            msgOutLbl.Dock = DockStyle.Fill;
            msgOutLbl.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgOutLbl.Location = new Point(3, 235);
            msgOutLbl.Name = "msgOutLbl";
            msgOutLbl.Size = new Size(540, 90);
            msgOutLbl.TabIndex = 7;
            msgOutLbl.Text = "0";
            // 
            // groupRadioBtns
            // 
            groupRadioBtns.Controls.Add(optionModulus);
            groupRadioBtns.Controls.Add(optionDivide);
            groupRadioBtns.Controls.Add(optionMultiply);
            groupRadioBtns.Controls.Add(optionSubtract);
            groupRadioBtns.Controls.Add(optionAdd);
            groupRadioBtns.Location = new Point(3, 3);
            groupRadioBtns.Name = "groupRadioBtns";
            groupRadioBtns.Size = new Size(294, 74);
            groupRadioBtns.TabIndex = 8;
            groupRadioBtns.TabStop = false;
            groupRadioBtns.Text = "Operations";
            // 
            // optionModulus
            // 
            optionModulus.AutoSize = true;
            optionModulus.Location = new Point(198, 19);
            optionModulus.Name = "optionModulus";
            optionModulus.Size = new Size(93, 19);
            optionModulus.TabIndex = 10;
            optionModulus.Text = "Modulus (%)";
            optionModulus.UseVisualStyleBackColor = true;
            optionModulus.CheckedChanged += optionModulus_CheckedChanged;
            // 
            // optionDivide
            // 
            optionDivide.AutoSize = true;
            optionDivide.Location = new Point(107, 47);
            optionDivide.Name = "optionDivide";
            optionDivide.Size = new Size(77, 19);
            optionDivide.TabIndex = 9;
            optionDivide.Text = "Divide (÷)";
            optionDivide.UseVisualStyleBackColor = true;
            optionDivide.CheckedChanged += optionDivide_CheckedChanged;
            // 
            // optionMultiply
            // 
            optionMultiply.AutoSize = true;
            optionMultiply.Location = new Point(107, 22);
            optionMultiply.Name = "optionMultiply";
            optionMultiply.Size = new Size(85, 19);
            optionMultiply.TabIndex = 9;
            optionMultiply.Text = "Multiply (*)";
            optionMultiply.UseVisualStyleBackColor = true;
            optionMultiply.CheckedChanged += optionMultiply_CheckedChanged;
            // 
            // optionSubtract
            // 
            optionSubtract.AutoSize = true;
            optionSubtract.Location = new Point(6, 47);
            optionSubtract.Name = "optionSubtract";
            optionSubtract.Size = new Size(85, 19);
            optionSubtract.TabIndex = 9;
            optionSubtract.Text = "Subtract (-)";
            optionSubtract.UseVisualStyleBackColor = true;
            optionSubtract.CheckedChanged += optionSubtract_CheckedChanged;
            // 
            // optionAdd
            // 
            optionAdd.AutoSize = true;
            optionAdd.Checked = true;
            optionAdd.Location = new Point(6, 22);
            optionAdd.Name = "optionAdd";
            optionAdd.Size = new Size(66, 19);
            optionAdd.TabIndex = 0;
            optionAdd.TabStop = true;
            optionAdd.Text = "Add (+)";
            optionAdd.UseVisualStyleBackColor = true;
            optionAdd.CheckedChanged += optionAdd_CheckedChanged;
            // 
            // groupOptionControls
            // 
            groupOptionControls.Controls.Add(optionVerbosity);
            groupOptionControls.Location = new Point(303, 3);
            groupOptionControls.Name = "groupOptionControls";
            groupOptionControls.Size = new Size(191, 52);
            groupOptionControls.TabIndex = 9;
            groupOptionControls.TabStop = false;
            // 
            // optionVerbosity
            // 
            optionVerbosity.AutoSize = true;
            optionVerbosity.Checked = true;
            optionVerbosity.CheckState = CheckState.Checked;
            optionVerbosity.Location = new Point(6, 16);
            optionVerbosity.Name = "optionVerbosity";
            optionVerbosity.Size = new Size(74, 19);
            optionVerbosity.TabIndex = 10;
            optionVerbosity.Text = "Verbosity";
            optionVerbosity.UseVisualStyleBackColor = true;
            // 
            // errorTooltip
            // 
            errorTooltip.ShowAlways = true;
            errorTooltip.ToolTipIcon = ToolTipIcon.Warning;
            errorTooltip.ToolTipTitle = "Warning";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(msgOutLbl, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(546, 325);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(leftOpLbl, 0, 0);
            tableLayoutPanel4.Controls.Add(leftOperandTxt, 0, 1);
            tableLayoutPanel4.Controls.Add(rightOperandTxt, 0, 3);
            tableLayoutPanel4.Controls.Add(rightOpLbl, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(540, 94);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupRadioBtns, 0, 0);
            tableLayoutPanel3.Controls.Add(groupOptionControls, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 103);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(540, 94);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnExit, 2, 0);
            tableLayoutPanel2.Controls.Add(btnReset, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCalculate, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 203);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(540, 29);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // frmRadioStar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 325);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(520, 300);
            Name = "frmRadioStar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += frmRadioStar_Load;
            groupRadioBtns.ResumeLayout(false);
            groupRadioBtns.PerformLayout();
            groupOptionControls.ResumeLayout(false);
            groupOptionControls.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculatorHandler.Calculate_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Program.mainform.leftOperandTxt.Text = string.Empty;
            Program.mainform.rightOperandTxt.Text = string.Empty;
            Program.mainform.msgOutLbl.Text = "0";
            Program.mainform.optionAdd.Checked = true;
            Program.mainform.optionVerbosity.Checked = true;
            Program.mainform.leftOperandTxt.Focus();
        }

        private void txt_user_input_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            if (textBox.Text.Any(c => !char.IsDigit(c) && c != '.'))
            {
                this.BeginInvoke(new Action(() =>
                {
                    int x = textBox.Width / 2;
                    int y = textBox.Height / 2;
                    errorTooltip.Show("Invalid character.", textBox, x, y, 3000);
                }));
            }

            string filtered = new string(
                textBox.Text.Where((c, i) => char.IsDigit(c) || (textBox.Text.Count(ch => ch == '.') < 2 && c == '.')).ToArray()
            );

            // If filtered text differs, replace the text and fix cursor position
            if (filtered != textBox.Text)
            {
                int oldPos = textBox.SelectionStart - (textBox.Text.Length - filtered.Length);
                textBox.Text = filtered;
                textBox.SelectionStart = Math.Max(oldPos, 0);
            }
        }

        public void frmRadioStar_Load(object sender, EventArgs e)
        {
            
        }

        private void optionModulus_CheckedChanged(object sender, EventArgs e)
        {
            CurrentOperations = Operation.Modulus;
        }

        private void optionDivide_CheckedChanged(object sender, EventArgs e)
        {
            CurrentOperations = Operation.Divide;
        }

        private void optionMultiply_CheckedChanged(object sender, EventArgs e)
        {
            CurrentOperations = Operation.Multiply;
        }

        private void optionSubtract_CheckedChanged(object sender, EventArgs e)
        {
            CurrentOperations = Operation.Subtract;
        }

        private void optionAdd_CheckedChanged(object sender, EventArgs e)
        {
            CurrentOperations = Operation.Add;
        }

        #endregion

        private Button btnExit;
        private Button btnReset;
        public TextBox leftOperandTxt;
        public TextBox rightOperandTxt;
        private Label leftOpLbl;
        private Label rightOpLbl;
        private Button btnCalculate;
        public Label msgOutLbl;
        private GroupBox groupRadioBtns;
        private RadioButton optionModulus;
        private RadioButton optionDivide;
        private RadioButton optionMultiply;
        private RadioButton optionSubtract;
        private RadioButton optionAdd;
        private GroupBox groupOptionControls;
        public CheckBox optionVerbosity;
        public ToolTip errorTooltip;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}

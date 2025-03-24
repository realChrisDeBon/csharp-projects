namespace Week2_DeBon_Project
{
    partial class frmSummer2023
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
            TOP_PARENT_LAYOUT = new TableLayoutPanel();
            TOP_ROW_LAYOUT = new TableLayoutPanel();
            LBL_TOP = new Label();
            TXT_MAIN = new TextBox();
            BOTTOM_ROW_LAYOUT = new TableLayoutPanel();
            BTN_WIPE = new Button();
            BTN_SAVE = new Button();
            BTN_CANCEL = new Button();
            BTN_CLOSE = new Button();
            LBL_MIDDLE = new Label();
            TOP_PARENT_LAYOUT.SuspendLayout();
            TOP_ROW_LAYOUT.SuspendLayout();
            BOTTOM_ROW_LAYOUT.SuspendLayout();
            SuspendLayout();
            // 
            // TOP_PARENT_LAYOUT
            // 
            TOP_PARENT_LAYOUT.ColumnCount = 1;
            TOP_PARENT_LAYOUT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TOP_PARENT_LAYOUT.Controls.Add(TOP_ROW_LAYOUT, 0, 0);
            TOP_PARENT_LAYOUT.Controls.Add(BOTTOM_ROW_LAYOUT, 0, 2);
            TOP_PARENT_LAYOUT.Controls.Add(LBL_MIDDLE, 0, 1);
            TOP_PARENT_LAYOUT.Dock = DockStyle.Fill;
            TOP_PARENT_LAYOUT.Location = new Point(0, 0);
            TOP_PARENT_LAYOUT.Name = "TOP_PARENT_LAYOUT";
            TOP_PARENT_LAYOUT.RowCount = 3;
            TOP_PARENT_LAYOUT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TOP_PARENT_LAYOUT.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            TOP_PARENT_LAYOUT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TOP_PARENT_LAYOUT.Size = new Size(800, 450);
            TOP_PARENT_LAYOUT.TabIndex = 0;
            // 
            // TOP_ROW_LAYOUT
            // 
            TOP_ROW_LAYOUT.ColumnCount = 2;
            TOP_ROW_LAYOUT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TOP_ROW_LAYOUT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            TOP_ROW_LAYOUT.Controls.Add(LBL_TOP, 0, 0);
            TOP_ROW_LAYOUT.Controls.Add(TXT_MAIN, 1, 0);
            TOP_ROW_LAYOUT.Dock = DockStyle.Fill;
            TOP_ROW_LAYOUT.Location = new Point(3, 3);
            TOP_ROW_LAYOUT.Name = "TOP_ROW_LAYOUT";
            TOP_ROW_LAYOUT.RowCount = 1;
            TOP_ROW_LAYOUT.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TOP_ROW_LAYOUT.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TOP_ROW_LAYOUT.Size = new Size(794, 39);
            TOP_ROW_LAYOUT.TabIndex = 0;
            // 
            // LBL_TOP
            // 
            LBL_TOP.AutoSize = true;
            LBL_TOP.Dock = DockStyle.Fill;
            LBL_TOP.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_TOP.Location = new Point(3, 0);
            LBL_TOP.Name = "LBL_TOP";
            LBL_TOP.Size = new Size(258, 39);
            LBL_TOP.TabIndex = 0;
            LBL_TOP.Text = "Enter Text Here";
            LBL_TOP.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TXT_MAIN
            // 
            TXT_MAIN.Dock = DockStyle.Fill;
            TXT_MAIN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TXT_MAIN.Location = new Point(267, 3);
            TXT_MAIN.Name = "TXT_MAIN";
            TXT_MAIN.PlaceholderText = "Enter text here...";
            TXT_MAIN.Size = new Size(524, 32);
            TXT_MAIN.TabIndex = 1;
            // 
            // BOTTOM_ROW_LAYOUT
            // 
            BOTTOM_ROW_LAYOUT.ColumnCount = 4;
            BOTTOM_ROW_LAYOUT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            BOTTOM_ROW_LAYOUT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            BOTTOM_ROW_LAYOUT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            BOTTOM_ROW_LAYOUT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            BOTTOM_ROW_LAYOUT.Controls.Add(BTN_WIPE, 0, 0);
            BOTTOM_ROW_LAYOUT.Controls.Add(BTN_SAVE, 1, 0);
            BOTTOM_ROW_LAYOUT.Controls.Add(BTN_CANCEL, 2, 0);
            BOTTOM_ROW_LAYOUT.Controls.Add(BTN_CLOSE, 3, 0);
            BOTTOM_ROW_LAYOUT.Dock = DockStyle.Fill;
            BOTTOM_ROW_LAYOUT.Location = new Point(3, 408);
            BOTTOM_ROW_LAYOUT.Name = "BOTTOM_ROW_LAYOUT";
            BOTTOM_ROW_LAYOUT.RowCount = 1;
            BOTTOM_ROW_LAYOUT.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BOTTOM_ROW_LAYOUT.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BOTTOM_ROW_LAYOUT.Size = new Size(794, 39);
            BOTTOM_ROW_LAYOUT.TabIndex = 1;
            // 
            // BTN_WIPE
            // 
            BTN_WIPE.Dock = DockStyle.Fill;
            BTN_WIPE.Location = new Point(3, 3);
            BTN_WIPE.Name = "BTN_WIPE";
            BTN_WIPE.Size = new Size(192, 33);
            BTN_WIPE.TabIndex = 0;
            BTN_WIPE.Text = "Wipe Clear";
            BTN_WIPE.UseVisualStyleBackColor = true;
            BTN_WIPE.Click += BTN_WIPE_Click;
            // 
            // BTN_SAVE
            // 
            BTN_SAVE.Dock = DockStyle.Fill;
            BTN_SAVE.Location = new Point(201, 3);
            BTN_SAVE.Name = "BTN_SAVE";
            BTN_SAVE.Size = new Size(192, 33);
            BTN_SAVE.TabIndex = 1;
            BTN_SAVE.Text = "Save";
            BTN_SAVE.UseVisualStyleBackColor = true;
            BTN_SAVE.Click += BTN_SAVE_Click;
            // 
            // BTN_CANCEL
            // 
            BTN_CANCEL.Dock = DockStyle.Fill;
            BTN_CANCEL.Location = new Point(399, 3);
            BTN_CANCEL.Name = "BTN_CANCEL";
            BTN_CANCEL.Size = new Size(192, 33);
            BTN_CANCEL.TabIndex = 2;
            BTN_CANCEL.Text = "Cancel";
            BTN_CANCEL.UseVisualStyleBackColor = true;
            BTN_CANCEL.Click += BTN_CANCEL_Click;
            // 
            // BTN_CLOSE
            // 
            BTN_CLOSE.Dock = DockStyle.Fill;
            BTN_CLOSE.Location = new Point(597, 3);
            BTN_CLOSE.Name = "BTN_CLOSE";
            BTN_CLOSE.Size = new Size(194, 33);
            BTN_CLOSE.TabIndex = 3;
            BTN_CLOSE.Text = "Close";
            BTN_CLOSE.UseVisualStyleBackColor = true;
            // 
            // LBL_MIDDLE
            // 
            LBL_MIDDLE.AutoSize = true;
            LBL_MIDDLE.Dock = DockStyle.Fill;
            LBL_MIDDLE.Font = new Font("Segoe UI Symbol", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_MIDDLE.Location = new Point(3, 45);
            LBL_MIDDLE.Name = "LBL_MIDDLE";
            LBL_MIDDLE.Size = new Size(794, 360);
            LBL_MIDDLE.TabIndex = 2;
            LBL_MIDDLE.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmSummer2023
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(TOP_PARENT_LAYOUT);
            Name = "frmSummer2023";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Summer 2023 Chris DeBon";
            TOP_PARENT_LAYOUT.ResumeLayout(false);
            TOP_PARENT_LAYOUT.PerformLayout();
            TOP_ROW_LAYOUT.ResumeLayout(false);
            TOP_ROW_LAYOUT.PerformLayout();
            BOTTOM_ROW_LAYOUT.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private TableLayoutPanel TOP_PARENT_LAYOUT;
        private TableLayoutPanel TOP_ROW_LAYOUT;
        private TableLayoutPanel BOTTOM_ROW_LAYOUT;
        private Button BTN_WIPE;
        private Button BTN_SAVE;
        private Label LBL_TOP;
        private Button BTN_CANCEL;
        private Button BTN_CLOSE;
        private TextBox TXT_MAIN;
        private Label LBL_MIDDLE;
        }
}

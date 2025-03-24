namespace DeBonLab_Project
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
            master_layout_panel = new TableLayoutPanel();
            colored_button_layout_panel = new TableLayoutPanel();
            btn_red = new Button();
            btn_orange = new Button();
            btn_yellow = new Button();
            btn_green = new Button();
            btn_cyan = new Button();
            btn_blue = new Button();
            btn_pink = new Button();
            btn_olive = new Button();
            btn_purple = new Button();
            numbered_button_layout = new TableLayoutPanel();
            btn_one = new Button();
            btn_two = new Button();
            btn_three = new Button();
            btn_four = new Button();
            btn_five = new Button();
            btn_six = new Button();
            btn_seven = new Button();
            btn_eight = new Button();
            btn_nine = new Button();
            lblTheDominator = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_exit = new Button();
            btn_clear = new Button();
            master_layout_panel.SuspendLayout();
            colored_button_layout_panel.SuspendLayout();
            numbered_button_layout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // master_layout_panel
            // 
            master_layout_panel.ColumnCount = 3;
            master_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            master_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            master_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            master_layout_panel.Controls.Add(colored_button_layout_panel, 1, 1);
            master_layout_panel.Controls.Add(numbered_button_layout, 1, 5);
            master_layout_panel.Controls.Add(lblTheDominator, 1, 3);
            master_layout_panel.Controls.Add(tableLayoutPanel1, 1, 7);
            master_layout_panel.Dock = DockStyle.Fill;
            master_layout_panel.Location = new Point(0, 0);
            master_layout_panel.Name = "master_layout_panel";
            master_layout_panel.RowCount = 9;
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 0.994879067F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2622433F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 0.994878948F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 45.0045357F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 0.994878948F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2622433F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 0.994878948F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5.496569F));
            master_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 0.994879F));
            master_layout_panel.Size = new Size(595, 991);
            master_layout_panel.TabIndex = 0;
            master_layout_panel.Paint += tableLayoutPanel1_Paint;
            // 
            // colored_button_layout_panel
            // 
            colored_button_layout_panel.ColumnCount = 5;
            colored_button_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1651859F));
            colored_button_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.25221825F));
            colored_button_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1651878F));
            colored_button_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.25221825F));
            colored_button_layout_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1651878F));
            colored_button_layout_panel.Controls.Add(btn_red, 0, 0);
            colored_button_layout_panel.Controls.Add(btn_orange, 2, 0);
            colored_button_layout_panel.Controls.Add(btn_yellow, 4, 0);
            colored_button_layout_panel.Controls.Add(btn_green, 0, 2);
            colored_button_layout_panel.Controls.Add(btn_cyan, 2, 2);
            colored_button_layout_panel.Controls.Add(btn_blue, 4, 2);
            colored_button_layout_panel.Controls.Add(btn_pink, 0, 4);
            colored_button_layout_panel.Controls.Add(btn_olive, 2, 4);
            colored_button_layout_panel.Controls.Add(btn_purple, 4, 4);
            colored_button_layout_panel.Dock = DockStyle.Fill;
            colored_button_layout_panel.Location = new Point(92, 12);
            colored_button_layout_panel.Name = "colored_button_layout_panel";
            colored_button_layout_panel.RowCount = 5;
            colored_button_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 31.1651821F));
            colored_button_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 3.252218F));
            colored_button_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 31.16519F));
            colored_button_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 3.252218F));
            colored_button_layout_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 31.1651859F));
            colored_button_layout_panel.Size = new Size(410, 214);
            colored_button_layout_panel.TabIndex = 0;
            // 
            // btn_red
            // 
            btn_red.BackColor = Color.FromArgb(192, 0, 0);
            btn_red.Dock = DockStyle.Fill;
            btn_red.Location = new Point(3, 3);
            btn_red.Name = "btn_red";
            btn_red.Size = new Size(121, 60);
            btn_red.TabIndex = 0;
            btn_red.Text = " ";
            btn_red.UseVisualStyleBackColor = false;
            btn_red.Click += btn_red_Click;
            // 
            // btn_orange
            // 
            btn_orange.BackColor = Color.FromArgb(255, 128, 0);
            btn_orange.Dock = DockStyle.Fill;
            btn_orange.Location = new Point(143, 3);
            btn_orange.Name = "btn_orange";
            btn_orange.Size = new Size(121, 60);
            btn_orange.TabIndex = 1;
            btn_orange.Text = " ";
            btn_orange.UseVisualStyleBackColor = false;
            btn_orange.Click += btn_orange_Click;
            // 
            // btn_yellow
            // 
            btn_yellow.BackColor = Color.Yellow;
            btn_yellow.Dock = DockStyle.Fill;
            btn_yellow.Location = new Point(283, 3);
            btn_yellow.Name = "btn_yellow";
            btn_yellow.Size = new Size(124, 60);
            btn_yellow.TabIndex = 2;
            btn_yellow.Text = " ";
            btn_yellow.UseVisualStyleBackColor = false;
            btn_yellow.Click += btn_yellow_Click;
            // 
            // btn_green
            // 
            btn_green.BackColor = Color.Lime;
            btn_green.Dock = DockStyle.Fill;
            btn_green.Location = new Point(3, 75);
            btn_green.Name = "btn_green";
            btn_green.Size = new Size(121, 60);
            btn_green.TabIndex = 3;
            btn_green.Text = " ";
            btn_green.UseVisualStyleBackColor = false;
            btn_green.Click += btn_green_Click;
            // 
            // btn_cyan
            // 
            btn_cyan.BackColor = Color.Cyan;
            btn_cyan.Dock = DockStyle.Fill;
            btn_cyan.Location = new Point(143, 75);
            btn_cyan.Name = "btn_cyan";
            btn_cyan.Size = new Size(121, 60);
            btn_cyan.TabIndex = 4;
            btn_cyan.Text = " ";
            btn_cyan.UseVisualStyleBackColor = false;
            btn_cyan.Click += btn_cyan_Click;
            // 
            // btn_blue
            // 
            btn_blue.BackColor = Color.Blue;
            btn_blue.Dock = DockStyle.Fill;
            btn_blue.Location = new Point(283, 75);
            btn_blue.Name = "btn_blue";
            btn_blue.Size = new Size(124, 60);
            btn_blue.TabIndex = 5;
            btn_blue.Text = " ";
            btn_blue.UseVisualStyleBackColor = false;
            btn_blue.Click += btn_blue_Click;
            // 
            // btn_pink
            // 
            btn_pink.BackColor = Color.FromArgb(255, 128, 255);
            btn_pink.Dock = DockStyle.Fill;
            btn_pink.Location = new Point(3, 147);
            btn_pink.Name = "btn_pink";
            btn_pink.Size = new Size(121, 64);
            btn_pink.TabIndex = 6;
            btn_pink.Text = " ";
            btn_pink.UseVisualStyleBackColor = false;
            btn_pink.Click += btn_pink_Click;
            // 
            // btn_olive
            // 
            btn_olive.BackColor = Color.Olive;
            btn_olive.Dock = DockStyle.Fill;
            btn_olive.Location = new Point(143, 147);
            btn_olive.Name = "btn_olive";
            btn_olive.Size = new Size(121, 64);
            btn_olive.TabIndex = 7;
            btn_olive.Text = " ";
            btn_olive.UseVisualStyleBackColor = false;
            btn_olive.Click += btn_olive_Click;
            // 
            // btn_purple
            // 
            btn_purple.BackColor = Color.Purple;
            btn_purple.Dock = DockStyle.Fill;
            btn_purple.Location = new Point(283, 147);
            btn_purple.Name = "btn_purple";
            btn_purple.Size = new Size(124, 64);
            btn_purple.TabIndex = 8;
            btn_purple.Text = " ";
            btn_purple.UseVisualStyleBackColor = false;
            btn_purple.Click += btn_purple_Click;
            // 
            // numbered_button_layout
            // 
            numbered_button_layout.ColumnCount = 5;
            numbered_button_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            numbered_button_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.125F));
            numbered_button_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            numbered_button_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.125F));
            numbered_button_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            numbered_button_layout.Controls.Add(btn_one, 0, 0);
            numbered_button_layout.Controls.Add(btn_two, 2, 0);
            numbered_button_layout.Controls.Add(btn_three, 4, 0);
            numbered_button_layout.Controls.Add(btn_four, 0, 2);
            numbered_button_layout.Controls.Add(btn_five, 2, 2);
            numbered_button_layout.Controls.Add(btn_six, 4, 2);
            numbered_button_layout.Controls.Add(btn_seven, 0, 4);
            numbered_button_layout.Controls.Add(btn_eight, 2, 4);
            numbered_button_layout.Controls.Add(btn_nine, 4, 4);
            numbered_button_layout.Dock = DockStyle.Fill;
            numbered_button_layout.Location = new Point(92, 695);
            numbered_button_layout.Name = "numbered_button_layout";
            numbered_button_layout.RowCount = 5;
            numbered_button_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            numbered_button_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 3.125F));
            numbered_button_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            numbered_button_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 3.125F));
            numbered_button_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            numbered_button_layout.Size = new Size(410, 214);
            numbered_button_layout.TabIndex = 1;
            // 
            // btn_one
            // 
            btn_one.Dock = DockStyle.Fill;
            btn_one.Location = new Point(3, 3);
            btn_one.Name = "btn_one";
            btn_one.Size = new Size(122, 60);
            btn_one.TabIndex = 0;
            btn_one.Text = "1";
            btn_one.UseVisualStyleBackColor = true;
            btn_one.Click += btn_one_Click;
            // 
            // btn_two
            // 
            btn_two.Dock = DockStyle.Fill;
            btn_two.Location = new Point(143, 3);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(122, 60);
            btn_two.TabIndex = 1;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = true;
            btn_two.Click += btn_two_Click;
            // 
            // btn_three
            // 
            btn_three.Dock = DockStyle.Fill;
            btn_three.Location = new Point(283, 3);
            btn_three.Name = "btn_three";
            btn_three.Size = new Size(124, 60);
            btn_three.TabIndex = 2;
            btn_three.Text = "3";
            btn_three.UseVisualStyleBackColor = true;
            btn_three.Click += btn_three_Click;
            // 
            // btn_four
            // 
            btn_four.Dock = DockStyle.Fill;
            btn_four.Location = new Point(3, 75);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(122, 60);
            btn_four.TabIndex = 3;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = true;
            btn_four.Click += btn_four_Click;
            // 
            // btn_five
            // 
            btn_five.Dock = DockStyle.Fill;
            btn_five.Location = new Point(143, 75);
            btn_five.Name = "btn_five";
            btn_five.Size = new Size(122, 60);
            btn_five.TabIndex = 4;
            btn_five.Text = "5";
            btn_five.UseVisualStyleBackColor = true;
            btn_five.Click += btn_five_Click;
            // 
            // btn_six
            // 
            btn_six.Dock = DockStyle.Fill;
            btn_six.Location = new Point(283, 75);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(124, 60);
            btn_six.TabIndex = 5;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = true;
            btn_six.Click += btn_six_Click;
            // 
            // btn_seven
            // 
            btn_seven.Dock = DockStyle.Fill;
            btn_seven.Location = new Point(3, 147);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(122, 64);
            btn_seven.TabIndex = 6;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = true;
            btn_seven.Click += btn_seven_Click;
            // 
            // btn_eight
            // 
            btn_eight.Dock = DockStyle.Fill;
            btn_eight.Location = new Point(143, 147);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(122, 64);
            btn_eight.TabIndex = 7;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = true;
            btn_eight.Click += btn_eight_Click;
            // 
            // btn_nine
            // 
            btn_nine.Dock = DockStyle.Fill;
            btn_nine.Location = new Point(283, 147);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(124, 64);
            btn_nine.TabIndex = 8;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = true;
            btn_nine.Click += btn_nine_Click;
            // 
            // lblTheDominator
            // 
            lblTheDominator.AutoSize = true;
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.Dock = DockStyle.Fill;
            lblTheDominator.Location = new Point(92, 238);
            lblTheDominator.Name = "lblTheDominator";
            lblTheDominator.Size = new Size(410, 445);
            lblTheDominator.TabIndex = 2;
            lblTheDominator.Text = " ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel1.Controls.Add(btn_exit, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_clear, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(92, 924);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(410, 48);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_exit
            // 
            btn_exit.Dock = DockStyle.Fill;
            btn_exit.Location = new Point(3, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(164, 42);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_clear
            // 
            btn_clear.DialogResult = DialogResult.Cancel;
            btn_clear.Dock = DockStyle.Fill;
            btn_clear.Location = new Point(241, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(166, 42);
            btn_clear.TabIndex = 1;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_clear;
            ClientSize = new Size(595, 991);
            Controls.Add(master_layout_panel);
            Name = "mainForm";
            Text = "DeBon - Programming Lab";
            master_layout_panel.ResumeLayout(false);
            master_layout_panel.PerformLayout();
            colored_button_layout_panel.ResumeLayout(false);
            numbered_button_layout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private TableLayoutPanel master_layout_panel;
        private TableLayoutPanel colored_button_layout_panel;
        private TableLayoutPanel numbered_button_layout;
        private Label lblTheDominator;
        private Button btn_red;
        private Button btn_orange;
        private Button btn_yellow;
        private Button btn_green;
        private Button btn_cyan;
        private Button btn_blue;
        private Button btn_pink;
        private Button btn_olive;
        private Button btn_purple;
        private Button btn_one;
        private Button btn_two;
        private Button btn_three;
        private Button btn_four;
        private Button btn_five;
        private Button btn_six;
        private Button btn_seven;
        private Button btn_eight;
        private Button btn_nine;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_exit;
        private Button btn_clear;
        }
}

using System;

namespace Module6MethodsProjectDL
{
    partial class frmRealID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_rightoperand = new System.Windows.Forms.TextBox();
            this.txt_leftoperand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.lbl_display = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_rightoperand
            // 
            this.txt_rightoperand.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rightoperand.Location = new System.Drawing.Point(157, 42);
            this.txt_rightoperand.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rightoperand.Name = "txt_rightoperand";
            this.txt_rightoperand.Size = new System.Drawing.Size(122, 32);
            this.txt_rightoperand.TabIndex = 1;
            this.txt_rightoperand.TextChanged += new System.EventHandler(this.NumericOrDecimalOnly_TextChanged);
            // 
            // txt_leftoperand
            // 
            this.txt_leftoperand.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leftoperand.Location = new System.Drawing.Point(157, 3);
            this.txt_leftoperand.Margin = new System.Windows.Forms.Padding(2);
            this.txt_leftoperand.Name = "txt_leftoperand";
            this.txt_leftoperand.Size = new System.Drawing.Size(122, 32);
            this.txt_leftoperand.TabIndex = 0;
            this.txt_leftoperand.TextChanged += new System.EventHandler(this.NumericOrDecimalOnly_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Left Operand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "RightOperand";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(8, 86);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(32, 37);
            this.btn_add.TabIndex = 2;
            this.btn_add.Tag = "0";
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(67, 86);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(32, 37);
            this.btn_minus.TabIndex = 3;
            this.btn_minus.Tag = "1";
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(127, 86);
            this.btn_multiply.Margin = new System.Windows.Forms.Padding(2);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(32, 37);
            this.btn_multiply.TabIndex = 4;
            this.btn_multiply.Tag = "2";
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(186, 86);
            this.btn_divide.Margin = new System.Windows.Forms.Padding(2);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(32, 37);
            this.btn_divide.TabIndex = 5;
            this.btn_divide.Tag = "3";
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btn_percent
            // 
            this.btn_percent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_percent.Location = new System.Drawing.Point(245, 86);
            this.btn_percent.Margin = new System.Windows.Forms.Padding(2);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(32, 37);
            this.btn_percent.TabIndex = 6;
            this.btn_percent.Tag = "4";
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            this.btn_percent.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // lbl_display
            // 
            this.lbl_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_display.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.Location = new System.Drawing.Point(8, 134);
            this.lbl_display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(269, 84);
            this.lbl_display.TabIndex = 9;
            this.lbl_display.Tag = "0";
            this.lbl_display.Text = "Answer Shows Here";
            this.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_display.TextChanged += new System.EventHandler(this.lbl_display_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(8, 222);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(114, 29);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(163, 222);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 29);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frmRealID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(286, 255);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_leftoperand);
            this.Controls.Add(this.txt_rightoperand);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRealID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valid ID Required";
            this.Load += new System.EventHandler(this.frmMethodActing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lbl_display_TextChanged(object sender, EventArgs e)
        {
            if (lbl_display.Tag.ToString() == "1")
            {
                lbl_display.ForeColor = System.Drawing.Color.Black;
                lbl_display.Tag = "0";
            }

        }

        #endregion

        public System.Windows.Forms.TextBox txt_rightoperand;
        public System.Windows.Forms.TextBox txt_leftoperand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_percent;
        public System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        }
}


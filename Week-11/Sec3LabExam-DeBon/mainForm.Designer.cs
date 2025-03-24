
namespace Sec3LabExam_DeBon
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
            groupBox1 = new GroupBox();
            optionPlaintext = new RadioButton();
            optionCipher = new RadioButton();
            label1 = new Label();
            userInput = new TextBox();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            btnExit = new Button();
            btnConvert = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optionPlaintext);
            groupBox1.Controls.Add(optionCipher);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(userInput);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // optionPlaintext
            // 
            optionPlaintext.AutoSize = true;
            optionPlaintext.Location = new Point(80, 69);
            optionPlaintext.Name = "optionPlaintext";
            optionPlaintext.Size = new Size(71, 19);
            optionPlaintext.TabIndex = 3;
            optionPlaintext.Text = "Plaintext";
            optionPlaintext.UseVisualStyleBackColor = true;
            // 
            // optionCipher
            // 
            optionCipher.AutoSize = true;
            optionCipher.Checked = true;
            optionCipher.Location = new Point(14, 69);
            optionCipher.Name = "optionCipher";
            optionCipher.Size = new Size(60, 19);
            optionCipher.TabIndex = 2;
            optionCipher.TabStop = true;
            optionCipher.Text = "Cipher";
            optionCipher.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Phrase to convert:";
            // 
            // userInput
            // 
            userInput.Location = new Point(6, 40);
            userInput.Name = "userInput";
            userInput.Size = new Size(527, 23);
            userInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnConvert);
            groupBox2.Location = new Point(12, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(539, 55);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(228, 20);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 23);
            btnReset.TabIndex = 2;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(431, 20);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(6, 20);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(102, 23);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "&Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 199);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cipher Tool";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            userInput.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Converted {CipherHandler.convertedMessages} messages", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton optionPlaintext;
        private RadioButton optionCipher;
        private Label label1;
        private TextBox userInput;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnConvert;
        private Button btnReset;
    }
}

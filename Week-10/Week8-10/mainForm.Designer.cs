namespace Week8_10
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
            txt_input = new TextBox();
            groupBox1 = new GroupBox();
            optionShowUWL = new RadioButton();
            optionShowWL = new RadioButton();
            frequenyCountGroup = new GroupBox();
            checkBox1 = new CheckBox();
            btn_clear = new Button();
            btn_exit = new Button();
            btn_process = new Button();
            statsGroupBox = new GroupBox();
            txt_output = new TextBox();
            lblSentenceCountTitle = new Label();
            lblAvgWordLenValue = new Label();
            lblAvgWordLenTitle = new Label();
            lblCharCountValue = new Label();
            lblCharCountTitle = new Label();
            lblUniqueWordCountValue = new Label();
            lblUniqueWordCountTitle = new Label();
            lblAvgUniqueWordLenTitle = new Label();
            lblAvgUniqueWordLenValue = new Label();
            lblWordCountValue = new Label();
            lblSentenceCountValue = new Label();
            lblWordCountTitle = new Label();
            groupBox1.SuspendLayout();
            frequenyCountGroup.SuspendLayout();
            statsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // txt_input
            // 
            txt_input.Location = new Point(12, 12);
            txt_input.Multiline = true;
            txt_input.Name = "txt_input";
            txt_input.ScrollBars = ScrollBars.Vertical;
            txt_input.Size = new Size(447, 199);
            txt_input.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optionShowUWL);
            groupBox1.Controls.Add(optionShowWL);
            groupBox1.Location = new Point(300, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 78);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Word List Type";
            // 
            // optionShowUWL
            // 
            optionShowUWL.AutoSize = true;
            optionShowUWL.Location = new Point(6, 47);
            optionShowUWL.Name = "optionShowUWL";
            optionShowUWL.Size = new Size(148, 19);
            optionShowUWL.TabIndex = 1;
            optionShowUWL.Text = "Show Unique Word List";
            optionShowUWL.UseVisualStyleBackColor = true;
            // 
            // optionShowWL
            // 
            optionShowWL.AutoSize = true;
            optionShowWL.Checked = true;
            optionShowWL.Location = new Point(6, 22);
            optionShowWL.Name = "optionShowWL";
            optionShowWL.Size = new Size(107, 19);
            optionShowWL.TabIndex = 0;
            optionShowWL.TabStop = true;
            optionShowWL.Text = "Show Word List";
            optionShowWL.UseVisualStyleBackColor = true;
            // 
            // frequenyCountGroup
            // 
            frequenyCountGroup.Controls.Add(checkBox1);
            frequenyCountGroup.Location = new Point(300, 301);
            frequenyCountGroup.Name = "frequenyCountGroup";
            frequenyCountGroup.Size = new Size(159, 50);
            frequenyCountGroup.TabIndex = 2;
            frequenyCountGroup.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Include Frequency";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(314, 386);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(67, 23);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(387, 386);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(67, 23);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_process
            // 
            btn_process.Location = new Point(347, 357);
            btn_process.Name = "btn_process";
            btn_process.Size = new Size(75, 23);
            btn_process.TabIndex = 5;
            btn_process.Text = "Process";
            btn_process.UseVisualStyleBackColor = true;
            // 
            // statsGroupBox
            // 
            statsGroupBox.Controls.Add(txt_output);
            statsGroupBox.Controls.Add(lblSentenceCountTitle);
            statsGroupBox.Controls.Add(lblAvgWordLenValue);
            statsGroupBox.Controls.Add(lblAvgWordLenTitle);
            statsGroupBox.Controls.Add(lblCharCountValue);
            statsGroupBox.Controls.Add(lblCharCountTitle);
            statsGroupBox.Controls.Add(lblUniqueWordCountValue);
            statsGroupBox.Controls.Add(lblUniqueWordCountTitle);
            statsGroupBox.Controls.Add(lblAvgUniqueWordLenTitle);
            statsGroupBox.Controls.Add(lblAvgUniqueWordLenValue);
            statsGroupBox.Controls.Add(lblWordCountValue);
            statsGroupBox.Controls.Add(lblSentenceCountValue);
            statsGroupBox.Controls.Add(lblWordCountTitle);
            statsGroupBox.Location = new Point(12, 217);
            statsGroupBox.Name = "statsGroupBox";
            statsGroupBox.Size = new Size(282, 190);
            statsGroupBox.TabIndex = 0;
            statsGroupBox.TabStop = false;
            // 
            // txt_output
            // 
            txt_output.Location = new Point(163, 16);
            txt_output.Multiline = true;
            txt_output.Name = "txt_output";
            txt_output.ScrollBars = ScrollBars.Vertical;
            txt_output.Size = new Size(113, 168);
            txt_output.TabIndex = 6;
            // 
            // lblSentenceCountTitle
            // 
            lblSentenceCountTitle.AutoSize = true;
            lblSentenceCountTitle.Location = new Point(8, 19);
            lblSentenceCountTitle.Name = "lblSentenceCountTitle";
            lblSentenceCountTitle.Size = new Size(94, 15);
            lblSentenceCountTitle.TabIndex = 6;
            lblSentenceCountTitle.Text = "Sentence Count:";
            // 
            // lblAvgWordLenValue
            // 
            lblAvgWordLenValue.AutoSize = true;
            lblAvgWordLenValue.Location = new Point(118, 99);
            lblAvgWordLenValue.Name = "lblAvgWordLenValue";
            lblAvgWordLenValue.Size = new Size(13, 15);
            lblAvgWordLenValue.TabIndex = 15;
            lblAvgWordLenValue.Text = "0";
            // 
            // lblAvgWordLenTitle
            // 
            lblAvgWordLenTitle.AutoSize = true;
            lblAvgWordLenTitle.Location = new Point(8, 99);
            lblAvgWordLenTitle.Name = "lblAvgWordLenTitle";
            lblAvgWordLenTitle.Size = new Size(103, 15);
            lblAvgWordLenTitle.TabIndex = 14;
            lblAvgWordLenTitle.Text = "Avg Word Length:";
            // 
            // lblCharCountValue
            // 
            lblCharCountValue.AutoSize = true;
            lblCharCountValue.Location = new Point(118, 79);
            lblCharCountValue.Name = "lblCharCountValue";
            lblCharCountValue.Size = new Size(13, 15);
            lblCharCountValue.TabIndex = 13;
            lblCharCountValue.Text = "0";
            // 
            // lblCharCountTitle
            // 
            lblCharCountTitle.AutoSize = true;
            lblCharCountTitle.Location = new Point(8, 79);
            lblCharCountTitle.Name = "lblCharCountTitle";
            lblCharCountTitle.Size = new Size(66, 15);
            lblCharCountTitle.TabIndex = 12;
            lblCharCountTitle.Text = "Characters:";
            // 
            // lblUniqueWordCountValue
            // 
            lblUniqueWordCountValue.AutoSize = true;
            lblUniqueWordCountValue.Location = new Point(118, 59);
            lblUniqueWordCountValue.Name = "lblUniqueWordCountValue";
            lblUniqueWordCountValue.Size = new Size(13, 15);
            lblUniqueWordCountValue.TabIndex = 11;
            lblUniqueWordCountValue.Text = "0";
            // 
            // lblUniqueWordCountTitle
            // 
            lblUniqueWordCountTitle.AutoSize = true;
            lblUniqueWordCountTitle.Location = new Point(8, 59);
            lblUniqueWordCountTitle.Name = "lblUniqueWordCountTitle";
            lblUniqueWordCountTitle.Size = new Size(85, 15);
            lblUniqueWordCountTitle.TabIndex = 10;
            lblUniqueWordCountTitle.Text = "Unique Words:";
            // 
            // lblAvgUniqueWordLenTitle
            // 
            lblAvgUniqueWordLenTitle.AutoSize = true;
            lblAvgUniqueWordLenTitle.Location = new Point(8, 119);
            lblAvgUniqueWordLenTitle.Name = "lblAvgUniqueWordLenTitle";
            lblAvgUniqueWordLenTitle.Size = new Size(94, 15);
            lblAvgUniqueWordLenTitle.TabIndex = 16;
            lblAvgUniqueWordLenTitle.Text = "Avg Unique Len:";
            // 
            // lblAvgUniqueWordLenValue
            // 
            lblAvgUniqueWordLenValue.AutoSize = true;
            lblAvgUniqueWordLenValue.Location = new Point(118, 119);
            lblAvgUniqueWordLenValue.Name = "lblAvgUniqueWordLenValue";
            lblAvgUniqueWordLenValue.Size = new Size(13, 15);
            lblAvgUniqueWordLenValue.TabIndex = 17;
            lblAvgUniqueWordLenValue.Text = "0";
            // 
            // lblWordCountValue
            // 
            lblWordCountValue.AutoSize = true;
            lblWordCountValue.Location = new Point(118, 39);
            lblWordCountValue.Name = "lblWordCountValue";
            lblWordCountValue.Size = new Size(13, 15);
            lblWordCountValue.TabIndex = 9;
            lblWordCountValue.Text = "0";
            // 
            // lblSentenceCountValue
            // 
            lblSentenceCountValue.AutoSize = true;
            lblSentenceCountValue.Location = new Point(118, 19);
            lblSentenceCountValue.Name = "lblSentenceCountValue";
            lblSentenceCountValue.Size = new Size(13, 15);
            lblSentenceCountValue.TabIndex = 7;
            lblSentenceCountValue.Text = "0";
            // 
            // lblWordCountTitle
            // 
            lblWordCountTitle.AutoSize = true;
            lblWordCountTitle.Location = new Point(8, 39);
            lblWordCountTitle.Name = "lblWordCountTitle";
            lblWordCountTitle.Size = new Size(75, 15);
            lblWordCountTitle.TabIndex = 8;
            lblWordCountTitle.Text = "Word Count:";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 419);
            Controls.Add(btn_process);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(frequenyCountGroup);
            Controls.Add(groupBox1);
            Controls.Add(txt_input);
            Controls.Add(statsGroupBox);
            Name = "mainForm";
            Text = "Word List Stats";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            frequenyCountGroup.ResumeLayout(false);
            frequenyCountGroup.PerformLayout();
            statsGroupBox.ResumeLayout(false);
            statsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void OptionShowUWL_CheckedChanged(object sender, EventArgs e)
        {
            // Enable frequency count box only if unique words option is checked
            checkBox1.Enabled = optionShowUWL.Checked;
            if (!optionShowUWL.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void Btn_process_Click(object sender, EventArgs e)
        {
            string originalText = txt_input.Text;

            if (string.IsNullOrWhiteSpace(originalText))
            {
                MessageBox.Show("Please enter some text to process.", "No Text Entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalCharacters = originalText.Length;

            int sentenceCount = System.Text.RegularExpressions.Regex.Matches(
                originalText, @"[.!?]").Count;

            string cleanedText = System.Text.RegularExpressions.Regex.Replace(
                originalText, @"[^a-zA-Z0-9'\-\s]", "");

            string[] tokens = cleanedText.Split(
                new[] { ' ', '\t', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            var wordList = tokens
                .Where(token => !System.Text.RegularExpressions.Regex.IsMatch(token, @"^\d+$"))
                .ToList();

            int totalWords = wordList.Count;
            int uniqueWords = wordList.Distinct(StringComparer.OrdinalIgnoreCase).Count();

            double avgWordLen = (totalWords > 0)
                ? wordList.Average(w => w.Length)
                : 0;

            double avgUniqueWordLen = (uniqueWords > 0)
                ? wordList.Select(w => w.ToLowerInvariant()).Distinct().Average(u => u.Length)
                : 0;

            lblSentenceCountValue.Text = sentenceCount.ToString();
            lblWordCountValue.Text = totalWords.ToString();
            lblUniqueWordCountValue.Text = uniqueWords.ToString();
            lblCharCountValue.Text = totalCharacters.ToString();
            lblAvgWordLenValue.Text = avgWordLen.ToString("F2");
            lblAvgUniqueWordLenValue.Text = avgUniqueWordLen.ToString("F2");

            if (optionShowWL.Checked)
            {
                txt_output.Text = string.Join(Environment.NewLine,
                    wordList.OrderBy(w => w, StringComparer.OrdinalIgnoreCase));
            }
            else if (optionShowUWL.Checked)
            {
                var distinctSortedWords = wordList
                    .Select(w => w.ToLowerInvariant())
                    .Distinct()
                    .OrderBy(w => w);

                if (checkBox1.Checked)
                {
                    var frequency = wordList.GroupBy(w => w.ToLowerInvariant())
                                            .ToDictionary(g => g.Key, g => g.Count());

                    txt_output.Text = string.Join(Environment.NewLine,
                        distinctSortedWords.Select(w => $"{w} ({frequency[w]})"));
                }
                else
                {
                    txt_output.Text = string.Join(Environment.NewLine, distinctSortedWords);
                }
            }
        }


        private void Btn_clear_Click(object sender, EventArgs e)
        {
            // Reset text box and statistics
            txt_input.Clear();
            lblSentenceCountValue.Text = "0";
            lblWordCountValue.Text = "0";
            lblUniqueWordCountValue.Text = "0";
            lblCharCountValue.Text = "0";
            lblAvgWordLenValue.Text = "0";
            lblAvgUniqueWordLenValue.Text = "0";

            // Reset options
            optionShowWL.Checked = true;
            optionShowUWL.Checked = false;
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
        }

        #endregion

        private TextBox txt_input;
        private GroupBox groupBox1;
        private RadioButton optionShowUWL;
        private RadioButton optionShowWL;
        private GroupBox frequenyCountGroup;
        private CheckBox checkBox1;
        private Button btn_clear;
        private Button btn_exit;
        private Button btn_process;
        private GroupBox statsGroupBox;
        private Label lblSentenceCountTitle;
        private Label lblSentenceCountValue;
        private Label lblWordCountTitle;
        private Label lblWordCountValue;
        private Label lblUniqueWordCountTitle;
        private Label lblUniqueWordCountValue;
        private Label lblCharCountTitle;
        private Label lblCharCountValue;
        private Label lblAvgWordLenTitle;
        private Label lblAvgWordLenValue;
        private Label lblAvgUniqueWordLenTitle;
        private Label lblAvgUniqueWordLenValue;
        private TextBox txt_output;
    }
}

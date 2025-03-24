
using System.Timers;

namespace CollectionsProject
{
    partial class frmCollections
    {
        public static System.Timers.Timer counterTimer = new System.Timers.Timer(200);

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
            btn_exit = new Button();
            btn_reset = new Button();
            txt_user_input = new TextBox();
            btn_add = new Button();
            btn_contents = new Button();
            btn_statistics = new Button();
            mainParentLayout = new TableLayoutPanel();
            mainViewButtonSplitLayout = new TableLayoutPanel();
            mainSplitter = new SplitContainer();
            contentsDisplay = new FlowLayoutPanel();
            statisticsDisplay = new FlowLayoutPanel();
            fncBtnLayout = new TableLayoutPanel();
            sidebarLayout = new TableLayoutPanel();
            collectionCounter = new Label();
            mainParentLayout.SuspendLayout();
            mainViewButtonSplitLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitter).BeginInit();
            mainSplitter.Panel1.SuspendLayout();
            mainSplitter.Panel2.SuspendLayout();
            mainSplitter.SuspendLayout();
            fncBtnLayout.SuspendLayout();
            sidebarLayout.SuspendLayout();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(108, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 23);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "&Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(3, 3);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 23);
            btn_reset.TabIndex = 1;
            btn_reset.Text = "&Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // txt_user_input
            // 
            txt_user_input.Dock = DockStyle.Fill;
            txt_user_input.Location = new Point(11, 3);
            txt_user_input.Name = "txt_user_input";
            txt_user_input.Size = new Size(146, 23);
            txt_user_input.TabIndex = 2;
            txt_user_input.TextChanged += txt_user_input_TextChanged;
            // 
            // btn_add
            // 
            btn_add.Dock = DockStyle.Fill;
            btn_add.Location = new Point(11, 33);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(146, 24);
            btn_add.TabIndex = 3;
            btn_add.Text = "&Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_contents
            // 
            btn_contents.Dock = DockStyle.Fill;
            btn_contents.Location = new Point(11, 63);
            btn_contents.Name = "btn_contents";
            btn_contents.Size = new Size(146, 24);
            btn_contents.TabIndex = 4;
            btn_contents.Text = "&Contents";
            btn_contents.UseVisualStyleBackColor = true;
            btn_contents.Click += btn_contents_Click;
            // 
            // btn_statistics
            // 
            btn_statistics.Dock = DockStyle.Fill;
            btn_statistics.Location = new Point(11, 93);
            btn_statistics.Name = "btn_statistics";
            btn_statistics.Size = new Size(146, 24);
            btn_statistics.TabIndex = 5;
            btn_statistics.Text = "&Statistics";
            btn_statistics.UseVisualStyleBackColor = true;
            btn_statistics.Click += btn_statistics_Click;
            // 
            // mainParentLayout
            // 
            mainParentLayout.BackColor = Color.OldLace;
            mainParentLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            mainParentLayout.ColumnCount = 2;
            mainParentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            mainParentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainParentLayout.Controls.Add(mainViewButtonSplitLayout, 1, 0);
            mainParentLayout.Controls.Add(sidebarLayout, 0, 0);
            mainParentLayout.Dock = DockStyle.Fill;
            mainParentLayout.Location = new Point(0, 0);
            mainParentLayout.Name = "mainParentLayout";
            mainParentLayout.RowCount = 1;
            mainParentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainParentLayout.Size = new Size(892, 540);
            mainParentLayout.TabIndex = 6;
            // 
            // mainViewButtonSplitLayout
            // 
            mainViewButtonSplitLayout.ColumnCount = 1;
            mainViewButtonSplitLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainViewButtonSplitLayout.Controls.Add(mainSplitter, 0, 0);
            mainViewButtonSplitLayout.Controls.Add(fncBtnLayout, 0, 1);
            mainViewButtonSplitLayout.Dock = DockStyle.Fill;
            mainViewButtonSplitLayout.Location = new Point(180, 4);
            mainViewButtonSplitLayout.Name = "mainViewButtonSplitLayout";
            mainViewButtonSplitLayout.RowCount = 2;
            mainViewButtonSplitLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainViewButtonSplitLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            mainViewButtonSplitLayout.Size = new Size(708, 532);
            mainViewButtonSplitLayout.TabIndex = 7;
            // 
            // mainSplitter
            // 
            mainSplitter.BorderStyle = BorderStyle.FixedSingle;
            mainSplitter.Dock = DockStyle.Fill;
            mainSplitter.Location = new Point(3, 3);
            mainSplitter.Name = "mainSplitter";
            // 
            // mainSplitter.Panel1
            // 
            mainSplitter.Panel1.BackColor = Color.FloralWhite;
            mainSplitter.Panel1.Controls.Add(contentsDisplay);
            // 
            // mainSplitter.Panel2
            // 
            mainSplitter.Panel2.BackColor = Color.AntiqueWhite;
            mainSplitter.Panel2.Controls.Add(statisticsDisplay);
            mainSplitter.Size = new Size(702, 491);
            mainSplitter.SplitterDistance = 234;
            mainSplitter.TabIndex = 7;
            // 
            // contentsDisplay
            // 
            contentsDisplay.Dock = DockStyle.Fill;
            contentsDisplay.FlowDirection = FlowDirection.TopDown;
            contentsDisplay.Location = new Point(0, 0);
            contentsDisplay.Name = "contentsDisplay";
            contentsDisplay.Size = new Size(232, 489);
            contentsDisplay.TabIndex = 0;
            // 
            // statisticsDisplay
            // 
            statisticsDisplay.Dock = DockStyle.Fill;
            statisticsDisplay.FlowDirection = FlowDirection.TopDown;
            statisticsDisplay.Location = new Point(0, 0);
            statisticsDisplay.Name = "statisticsDisplay";
            statisticsDisplay.Size = new Size(462, 489);
            statisticsDisplay.TabIndex = 0;
            // 
            // fncBtnLayout
            // 
            fncBtnLayout.BackColor = Color.RosyBrown;
            fncBtnLayout.ColumnCount = 4;
            fncBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            fncBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            fncBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            fncBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fncBtnLayout.Controls.Add(btn_reset, 0, 0);
            fncBtnLayout.Controls.Add(btn_exit, 2, 0);
            fncBtnLayout.Dock = DockStyle.Fill;
            fncBtnLayout.Location = new Point(3, 500);
            fncBtnLayout.Name = "fncBtnLayout";
            fncBtnLayout.RowCount = 1;
            fncBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            fncBtnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            fncBtnLayout.Size = new Size(702, 29);
            fncBtnLayout.TabIndex = 0;
            // 
            // sidebarLayout
            // 
            sidebarLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebarLayout.BackColor = Color.RosyBrown;
            sidebarLayout.ColumnCount = 3;
            sidebarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            sidebarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            sidebarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            sidebarLayout.Controls.Add(txt_user_input, 1, 0);
            sidebarLayout.Controls.Add(btn_statistics, 1, 3);
            sidebarLayout.Controls.Add(btn_add, 1, 1);
            sidebarLayout.Controls.Add(btn_contents, 1, 2);
            sidebarLayout.Controls.Add(collectionCounter, 1, 4);
            sidebarLayout.Location = new Point(4, 4);
            sidebarLayout.Name = "sidebarLayout";
            sidebarLayout.RowCount = 6;
            sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sidebarLayout.Size = new Size(169, 532);
            sidebarLayout.TabIndex = 7;
            // 
            // collectionCounter
            // 
            collectionCounter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            collectionCounter.AutoSize = true;
            collectionCounter.ImageAlign = ContentAlignment.MiddleLeft;
            collectionCounter.Location = new Point(11, 120);
            collectionCounter.Name = "collectionCounter";
            collectionCounter.Size = new Size(101, 30);
            collectionCounter.TabIndex = 6;
            collectionCounter.Text = "Collection count: ";
            collectionCounter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmCollections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 540);
            Controls.Add(mainParentLayout);
            Name = "frmCollections";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Collection Lab";
            Load += frmCollections_Load;
            KeyDown += frmCollection_KeyDown;
            KeyPress += frmCollection_KeyPress;
            mainParentLayout.ResumeLayout(false);
            mainViewButtonSplitLayout.ResumeLayout(false);
            mainSplitter.Panel1.ResumeLayout(false);
            mainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitter).EndInit();
            mainSplitter.ResumeLayout(false);
            fncBtnLayout.ResumeLayout(false);
            sidebarLayout.ResumeLayout(false);
            sidebarLayout.PerformLayout();
            ResumeLayout(false);
        }

        public void syncValues(object sender, ElapsedEventArgs e)
        {
            if (collectionCounter.InvokeRequired)
            {
                collectionCounter.Invoke(new Action(() =>
                {
                    collectionCounter.Text = "Collection count: " + CollectionManager.collection.Count;
                }));
            }
            else
            {
                collectionCounter.Text = "Collection count: " + CollectionManager.collection.Count;
            }
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            StatisticsDisplayAdapter.PopulateStatisticsDisplay();
        }

        private void btn_contents_Click(object sender, EventArgs e)
        {
            CollectionDisplayAdapter.PopulateContentsDisplay();
        }

        private void frmCollection_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCollection_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        private void txt_user_input_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Filter out invalid characters but allow one negative sign at the beginning
            string filtered = new string(
                textBox.Text.Where((c, i) => char.IsDigit(c) || (c == '-' && i == 0)).ToArray()
            );

            // If filtered text differs, replace the text and fix cursor position
            if (filtered != textBox.Text)
            {
                int oldPos = textBox.SelectionStart - (textBox.Text.Length - filtered.Length);
                textBox.Text = filtered;
                textBox.SelectionStart = Math.Max(oldPos, 0);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            CollectionManager.ClearCollection();
            CollectionDisplayAdapter.WipeContentsDisplay();
            StatisticsDisplayAdapter.WipeStatisticsDisplay();
            Program.frmCollections.txt_user_input.Clear();

        }

        #endregion

        private Button btn_exit;
        private Button btn_reset;
        public TextBox txt_user_input;
        private Button btn_add;
        private Button btn_contents;
        private Button btn_statistics;
        private TableLayoutPanel mainParentLayout;
        private TableLayoutPanel sidebarLayout;
        private TableLayoutPanel mainViewButtonSplitLayout;
        private TableLayoutPanel fncBtnLayout;
        private SplitContainer mainSplitter;
        public FlowLayoutPanel contentsDisplay;
        public FlowLayoutPanel statisticsDisplay;
        public Label collectionCounter;
    }
}

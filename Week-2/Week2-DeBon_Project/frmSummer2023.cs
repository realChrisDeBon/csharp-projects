// Christopher Brian DeBon II
// ITD 2343 - OOP Using C# -  Week 2 Programming Lab - Spring 2025
// Due: 01/19/2025 23:59

namespace Week2_DeBon_Project
    {
    public partial class frmSummer2023 : Form
        {
        public frmSummer2023()
            {
            InitializeComponent();
            }

        // This is the event handle that subscribes to the button's CLICK event
        private void BTN_CLOSE_Click(object? sender, EventArgs e)
            {
            Application.Exit(); // close the application
            }

        // This is the event handle that subscribes to the button's CLICK event
        private void BTN_CANCEL_Click(object? sender, EventArgs e)
            {
            TXT_MAIN.Text = string.Empty; // this is the same as "" but I like to be explicit
            }

        // This is the event handle that subscribes to the button's CLICK event
        private void BTN_WIPE_Click(object? sender, EventArgs e)
            {
            LBL_MIDDLE.Text = string.Empty; // wipe the big middle label
            }

        // This is the event handle that subscribes to the button's CLICK event
        private void BTN_SAVE_Click(object? sender, EventArgs e)
            {
            LBL_MIDDLE.Text += TXT_MAIN.Text + Environment.NewLine; // append the textbox text to the middle label
            }
        }
    }
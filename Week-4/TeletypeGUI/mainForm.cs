namespace TeletypeGUI
{
    public partial class mainForm : Form
        {

        public List<string> OutboundMessages = new List<string>();

        public mainForm()
            {
            InitializeComponent();
            }

        private void button36_Click(object sender, EventArgs e)
            {
            txt_main.Clear();
            }

        private void btn_exit_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void btn_send_Click(object sender, EventArgs e)
            {
            OutboundMessages.Add(txt_main.Text); // misc record keeping
            lbl_main.Text = "Previous message: " + txt_main.Text;
            txt_main.Clear();
            }

        private void btn_space_Click(object sender, EventArgs e)
            {
            txt_main.Text += " ";
            }
        }
    }
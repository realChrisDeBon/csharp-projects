namespace Week8_10
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            optionShowUWL.CheckedChanged += OptionShowUWL_CheckedChanged;
            btn_clear.Click += Btn_clear_Click;
            btn_process.Click += Btn_process_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

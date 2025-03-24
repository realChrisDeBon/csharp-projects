global using static BaseConverter.ConversionHandler;

namespace BaseConverter
{
    public partial class mainForm : Form
    {
        public int targetNumber => int.Parse(txt_input.Text);
        public int targetBase => int.Parse(txt_baseof.Text);

        public mainForm()
        {
            InitializeComponent();
            ConversionHandler.formReference = this; // pass self reference to conversion handler
        }

        private void lbl_instruct_input_Click(object sender, EventArgs e)
        {

        }
    }
}
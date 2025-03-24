namespace Sec3LabExam_DeBon
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.AcceptButton = btnConvert;
            this.CancelButton = btnExit;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputText = userInput.Text;

            

            if(string.IsNullOrEmpty(inputText)) {
                MessageBox.Show("Please enter a value to convert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string outputText;

            if (optionCipher.Checked)
            {
                outputText = CipherHandler.Encode(inputText);
            }
            else if (optionPlaintext.Checked)
            {
                outputText = CipherHandler.Decode(inputText);
            }
            else
            {
                outputText = inputText;
            }

            userInput.Text = outputText;
        }
    }
}

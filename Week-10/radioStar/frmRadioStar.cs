global using static radioStar.CalculatorHandler;

namespace radioStar
{
    public partial class frmRadioStar : Form
    {
        public frmRadioStar()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

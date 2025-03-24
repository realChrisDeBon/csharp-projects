namespace CollectionsProject
{
    public partial class frmCollections : Form
    {
        public frmCollections()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_user_input.Text != "")
            {
                CollectionManager.AddToCollection(int.Parse(txt_user_input.Text));
            }
            else
            {
                MessageBox.Show("Please enter a value to add to the collection.", "No Value Entered Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCollections_Load(object sender, EventArgs e)
        {
            counterTimer.Elapsed += syncValues;
            counterTimer.Start();
        }
    }
}
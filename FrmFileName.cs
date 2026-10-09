namespace CreateTextFileApp
{
    public partial class FrmFileName : Form
    {
        // Public static variable to hold the filename accessible by FrmLab1
        public static string SetFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            // Set the value of SetFileName and concatenate with ".txt"
            SetFileName = txtFileName.Text + ".txt";

            // Close the form
            this.Close();
        }
    }
}

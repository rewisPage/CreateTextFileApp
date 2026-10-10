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

            // Validate the filename received from FrmFileName
            // FrmFileName.SetFileName will be "<name>.txt" when the user clicked OK in that dialog
            if (string.IsNullOrWhiteSpace(FrmFileName.SetFileName) || FrmFileName.SetFileName == ".txt")
            {
                MessageBox.Show("No file name was provided. Please enter a valid file name.", "Invalid File Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for invalid file name characters
            char[] invalidChars = Path.GetInvalidFileNameChars();
            foreach (char c in invalidChars)
            {
                if (FrmFileName.SetFileName.Contains(c))
                {
                    MessageBox.Show("The file name contains invalid characters. Please choose a different name.", "Invalid File Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();

            // Close the form
            this.Close();
        }
    }
}

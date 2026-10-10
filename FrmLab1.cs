namespace CreateTextFileApp
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Step 3a: Declare an instance of FrmFileName and call ShowDialog()
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            // Step 3b: Declare a string variable named getInput and get the value of txtInput
            string getInput = txtInput.Text;

            // Get the MyDocuments folder path
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, FrmFileName.SetFileName);

            // If the file already exists, confirm overwrite
            if (File.Exists(fullPath))
            {
                var overwrite = MessageBox.Show($"The file '{FrmFileName.SetFileName}' already exists. Do you want to overwrite it?", "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (overwrite != DialogResult.Yes)
                    return;
            }

            // Write input text to the specified file inside MyDocuments with error handling
            try
            {
                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    outputFile.WriteLine(getInput);
                }

                Console.WriteLine(getInput);
                MessageBox.Show($"File saved to: {fullPath}", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"An I/O error occurred while writing the file: {ioEx.Message}", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
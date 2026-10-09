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

            // Write input text to the specified file inside MyDocuments
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }
    }
}
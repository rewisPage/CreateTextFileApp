namespace CreateTextFileApp
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();

            frmRegistration.Show();

            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lvStudentInfo.Items.Clear();

            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Select Student Record";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lvStudentInfo.Items.Clear();

                string path = openFileDialog1.FileName;

                lblFileName.Text = Path.GetFileName(path);

                using (StreamReader reader = File.OpenText(path))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lvStudentInfo.Items.Add(line);
                    }
                }

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvStudentInfo.Items.Clear();
            lblFileName.Text = "No File Selected";

        }
    }
}

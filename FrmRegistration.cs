using System;
using System.IO;
using System.Windows.Forms;

namespace CreateTextFileApp
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            cmbProgram.Items.Add("BS in Information Technology");
            cmbProgram.Items.Add("BS in Computer Engineering");
            cmbProgram.Items.Add("BS in Information Systems");

            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate each field and provide specific feedback
            // Student number
            string studentNo = txtStudentNo.Text?.Trim();
            if (string.IsNullOrWhiteSpace(studentNo))
            {
                MessageBox.Show("Student number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNo.Focus();
                return;
            }

            // Ensure student number doesn't contain invalid file name characters (it's used as filename)
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                if (studentNo.Contains(c))
                {
                    MessageBox.Show("Student number contains invalid characters for a file name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudentNo.Focus();
                    return;
                }
            }

            // Ensure student number contains digits only (no letters)
            foreach (char ch in studentNo)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Student number must contain digits only (no letters or symbols).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudentNo.Focus();
                    return;
                }
            }

            // Last name and first name
            string lastName = txtLastName.Text?.Trim();
            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            string firstName = txtFirstName.Text?.Trim();
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            // Middle initial (optional but if provided must be a single letter)
            string middleInit = txtMiddleInitial.Text?.Trim();
            if (!string.IsNullOrEmpty(middleInit) && middleInit.Length != 1)
            {
                MessageBox.Show("Middle initial must be a single character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMiddleInitial.Focus();
                return;
            }

            // Age - must be an integer within a reasonable range
            string ageText = txtAge.Text?.Trim();
            if (string.IsNullOrWhiteSpace(ageText) || !int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }
            if (age <= 0 || age > 120)
            {
                MessageBox.Show("Please enter a realistic age value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            // Program and gender selection
            if (cmbProgram.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProgram.DroppedDown = true;
                return;
            }

            if (cmbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.DroppedDown = true;
                return;
            }

            // Contact number (basic validation: digits only and reasonable length)
            string contactNo = txtContactNo.Text?.Trim();
            if (string.IsNullOrWhiteSpace(contactNo))
            {
                MessageBox.Show("Contact number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNo.Focus();
                return;
            }
            foreach (char ch in contactNo)
            {
                if (!char.IsDigit(ch) && ch != '+' && ch != '-')
                {
                    MessageBox.Show("Contact number contains invalid characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactNo.Focus();
                    return;
                }
            }

            // Build file path and student info
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = studentNo + ".txt";
            string fullPath = Path.Combine(docPath, fileName);

            string[] studentInfo =
            {
                "Student No.: " + studentNo,
                "Last Name: " + lastName,
                "First Name: " + firstName,
                "Middle Initial: " + middleInit,
                "Age: " + age,
                "Program: " + cmbProgram.Text,
                "Gender: " + cmbGender.Text,
                "Birthday: " + dtpBirthday.Value.ToShortDateString(),
                "Contact No.: " + contactNo
            };

            // Write file with explicit exception handling for IO operations
            try
            {
                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    foreach (string data in studentInfo)
                    {
                        outputFile.WriteLine(data);
                    }
                }

                MessageBox.Show(
                    "Registration information saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MessageBox.Show($"File saved to: {fullPath}", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"An I/O error occurred while saving registration: {ioEx.Message}", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtAge.Clear();
            txtContactNo.Clear();

            cmbProgram.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;

            dtpBirthday.Value = DateTime.Now;

            txtStudentNo.Focus();
        }
    }
}

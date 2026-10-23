namespace CreateTextFileApp
{
    partial class FrmStudentRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnFind = new Button();
            lvStudentInfo = new ListView();
            label3 = new Label();
            btnRegister = new Button();
            btnUpload = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblFileName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 1;
            label1.Text = "📝 View Records";
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(446, 105);
            btnFind.Margin = new Padding(10);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(124, 39);
            btnFind.TabIndex = 20;
            btnFind.Text = "🔍︎ Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // lvStudentInfo
            // 
            lvStudentInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvStudentInfo.Location = new Point(19, 105);
            lvStudentInfo.Name = "lvStudentInfo";
            lvStudentInfo.Size = new Size(414, 319);
            lvStudentInfo.TabIndex = 21;
            lvStudentInfo.UseCompatibleStateImageBehavior = false;
            lvStudentInfo.View = View.List;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 71);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 22;
            label3.Text = "File Name: ";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(446, 164);
            btnRegister.Margin = new Padding(10);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(124, 39);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "📃 Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(446, 223);
            btnUpload.Margin = new Padding(10);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(124, 39);
            btnUpload.TabIndex = 24;
            btnUpload.Text = "📂 Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.Location = new Point(106, 71);
            lblFileName.Margin = new Padding(10);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(129, 21);
            lblFileName.TabIndex = 25;
            lblFileName.Text = "No File Selected";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 450);
            Controls.Add(lblFileName);
            Controls.Add(btnUpload);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(lvStudentInfo);
            Controls.Add(btnFind);
            Controls.Add(label1);
            Name = "FrmStudentRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFind;
        private ListView lvStudentInfo;
        private Label label3;
        private Button btnRegister;
        private Button btnUpload;
        private OpenFileDialog openFileDialog1;
        private Label lblFileName;
    }
}
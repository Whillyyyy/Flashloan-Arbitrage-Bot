namespace Bank2
{
    partial class AddAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccounts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtOccupation = new TextBox();
            txtIncome = new TextBox();
            cbEducation = new ComboBox();
            cbGender = new ComboBox();
            btnSubmit = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            AccountDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 903);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(495, 19);
            label1.Name = "label1";
            label1.Size = new Size(302, 38);
            label1.TabIndex = 6;
            label1.Text = "New Account Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(288, 143);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(451, 143);
            label3.Name = "label3";
            label3.Size = new Size(74, 26);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(643, 143);
            label4.Name = "label4";
            label4.Size = new Size(91, 26);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(840, 143);
            label5.Name = "label5";
            label5.Size = new Size(124, 26);
            label5.TabIndex = 10;
            label5.Text = "Occupation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(288, 249);
            label6.Name = "label6";
            label6.Size = new Size(111, 26);
            label6.TabIndex = 11;
            label6.Text = "Education";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(451, 249);
            label7.Name = "label7";
            label7.Size = new Size(86, 26);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(840, 249);
            label8.Name = "label8";
            label8.Size = new Size(86, 26);
            label8.TabIndex = 13;
            label8.Text = "Income";
            // 
            // txtName
            // 
            txtName.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(288, 173);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 32);
            txtName.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(451, 173);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(147, 32);
            txtPhone.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(643, 173);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(147, 141);
            txtAddress.TabIndex = 16;
            // 
            // txtOccupation
            // 
            txtOccupation.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOccupation.Location = new Point(840, 173);
            txtOccupation.Margin = new Padding(3, 4, 3, 4);
            txtOccupation.Name = "txtOccupation";
            txtOccupation.Size = new Size(147, 32);
            txtOccupation.TabIndex = 17;
            // 
            // txtIncome
            // 
            txtIncome.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIncome.Location = new Point(840, 280);
            txtIncome.Margin = new Padding(3, 4, 3, 4);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(147, 32);
            txtIncome.TabIndex = 18;
            // 
            // cbEducation
            // 
            cbEducation.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEducation.FormattingEnabled = true;
            cbEducation.Items.AddRange(new object[] { "High School Graduate", "Senior High School ", "College Graduate" });
            cbEducation.Location = new Point(288, 285);
            cbEducation.Margin = new Padding(3, 4, 3, 4);
            cbEducation.Name = "cbEducation";
            cbEducation.Size = new Size(138, 34);
            cbEducation.TabIndex = 19;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cbGender.Location = new Point(451, 285);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(138, 34);
            cbGender.TabIndex = 20;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Blue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(371, 347);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 41);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Blue;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(562, 347);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 41);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button2_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Blue;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(749, 347);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 41);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Delete";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AccountDGV
            // 
            AccountDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            AccountDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AccountDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AccountDGV.ColumnHeadersHeight = 24;
            AccountDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AccountDGV.DefaultCellStyle = dataGridViewCellStyle3;
            AccountDGV.GridColor = Color.FromArgb(231, 229, 255);
            AccountDGV.Location = new Point(49, 453);
            AccountDGV.Margin = new Padding(3, 4, 3, 4);
            AccountDGV.Name = "AccountDGV";
            AccountDGV.RowHeadersVisible = false;
            AccountDGV.RowHeadersWidth = 51;
            AccountDGV.RowTemplate.Height = 24;
            AccountDGV.Size = new Size(1185, 449);
            AccountDGV.TabIndex = 24;
            AccountDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            AccountDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            AccountDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            AccountDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            AccountDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            AccountDGV.ThemeStyle.BackColor = Color.White;
            AccountDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            AccountDGV.ThemeStyle.HeaderStyle.BackColor = Color.Blue;
            AccountDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            AccountDGV.ThemeStyle.HeaderStyle.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AccountDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AccountDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AccountDGV.ThemeStyle.HeaderStyle.Height = 24;
            AccountDGV.ThemeStyle.ReadOnly = false;
            AccountDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            AccountDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AccountDGV.ThemeStyle.RowsStyle.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AccountDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            AccountDGV.ThemeStyle.RowsStyle.Height = 24;
            AccountDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            AccountDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            AccountDGV.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1194, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1152, 0);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(49, 0);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // AddAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 903);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(AccountDGV);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnSubmit);
            Controls.Add(cbGender);
            Controls.Add(cbEducation);
            Controls.Add(txtIncome);
            Controls.Add(txtOccupation);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAccounts";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtOccupation;
        private TextBox txtIncome;
        private ComboBox cbEducation;
        private ComboBox cbGender;
        private Button btnSubmit;
        private Button btnEdit;
        private Button btnCancel;
        private Guna.UI2.WinForms.Guna2DataGridView AccountDGV;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}
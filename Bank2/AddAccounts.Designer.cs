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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(42, 677);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 31);
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
            label1.Location = new Point(433, 14);
            label1.Name = "label1";
            label1.Size = new Size(239, 29);
            label1.TabIndex = 6;
            label1.Text = "New Account Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(252, 107);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(395, 107);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(563, 107);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(735, 107);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 10;
            label5.Text = "Occupation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(252, 187);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 11;
            label6.Text = "Education";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(395, 187);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(735, 187);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 13;
            label8.Text = "Income";
            // 
            // txtName
            // 
            txtName.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(252, 130);
            txtName.Name = "txtName";
            txtName.Size = new Size(129, 27);
            txtName.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(395, 130);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(129, 27);
            txtPhone.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(563, 130);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(129, 107);
            txtAddress.TabIndex = 16;
            
            // 
            // txtOccupation
            // 
            txtOccupation.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOccupation.Location = new Point(735, 130);
            txtOccupation.Name = "txtOccupation";
            txtOccupation.Size = new Size(129, 27);
            txtOccupation.TabIndex = 17;
            // 
            // txtIncome
            // 
            txtIncome.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIncome.Location = new Point(735, 210);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(129, 27);
            txtIncome.TabIndex = 18;
            // 
            // cbEducation
            // 
            cbEducation.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEducation.FormattingEnabled = true;
            cbEducation.Items.AddRange(new object[] { "High School Graduate", "Senior High School ", "College Graduate" });
            cbEducation.Location = new Point(252, 214);
            cbEducation.Name = "cbEducation";
            cbEducation.Size = new Size(121, 28);
            cbEducation.TabIndex = 19;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cbGender.Location = new Point(395, 214);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 28);
            cbGender.TabIndex = 20;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Blue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(325, 260);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(96, 31);
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
            btnEdit.Location = new Point(492, 260);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 31);
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
            btnCancel.Location = new Point(655, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 31);
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
            AccountDGV.Location = new Point(43, 340);
            AccountDGV.Name = "AccountDGV";
            AccountDGV.RowHeadersVisible = false;
            AccountDGV.RowTemplate.Height = 24;
            AccountDGV.Size = new Size(1037, 337);
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
            pictureBox1.Location = new Point(1045, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 677);
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
            Name = "AddAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAccounts";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
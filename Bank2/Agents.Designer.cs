namespace Bank2
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            AgentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            btnCancel = new Button();
            btnEdit = new Button();
            btnSubmit = new Button();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(989, -50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // AgentDGV
            // 
            AgentDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            AgentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AgentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AgentDGV.ColumnHeadersHeight = 24;
            AgentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AgentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            AgentDGV.GridColor = Color.FromArgb(231, 229, 255);
            AgentDGV.Location = new Point(44, 292);
            AgentDGV.Name = "AgentDGV";
            AgentDGV.RowHeadersVisible = false;
            AgentDGV.RowHeadersWidth = 51;
            AgentDGV.RowTemplate.Height = 24;
            AgentDGV.Size = new Size(988, 337);
            AgentDGV.TabIndex = 44;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            AgentDGV.ThemeStyle.BackColor = Color.White;
            AgentDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            AgentDGV.ThemeStyle.HeaderStyle.BackColor = Color.Blue;
            AgentDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            AgentDGV.ThemeStyle.HeaderStyle.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AgentDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AgentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AgentDGV.ThemeStyle.HeaderStyle.Height = 24;
            AgentDGV.ThemeStyle.ReadOnly = false;
            AgentDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            AgentDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AgentDGV.ThemeStyle.RowsStyle.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AgentDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            AgentDGV.ThemeStyle.RowsStyle.Height = 24;
            AgentDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            AgentDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            AgentDGV.CellContentClick += AgentDGV_CellContentClick;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Blue;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(634, 223);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 31);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Delete";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Blue;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(471, 223);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 31);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Blue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(304, 223);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(96, 31);
            btnSubmit.TabIndex = 41;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(714, 93);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(129, 32);
            txtPhone.TabIndex = 37;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(542, 93);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(129, 107);
            txtAddress.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(374, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(129, 32);
            txtPassword.TabIndex = 35;
            // 
            // txtName
            // 
            txtName.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(231, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(129, 32);
            txtName.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(714, 70);
            label5.Name = "label5";
            label5.Size = new Size(74, 26);
            label5.TabIndex = 30;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(542, 70);
            label4.Name = "label4";
            label4.Size = new Size(91, 26);
            label4.TabIndex = 29;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(374, 70);
            label3.Name = "label3";
            label3.Size = new Size(105, 26);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(231, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 27;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(377, -36);
            label1.Name = "label1";
            label1.Size = new Size(302, 38);
            label1.TabIndex = 26;
            label1.Text = "New Account Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(42, 630);
            panel1.TabIndex = 46;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(424, 8);
            label9.Name = "label9";
            label9.Size = new Size(250, 38);
            label9.TabIndex = 47;
            label9.Text = "Manage Agents";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(991, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(48, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(957, 0);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 50;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Agents
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 630);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(AgentDGV);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnSubmit);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agents";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView AgentDGV;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnSubmit;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
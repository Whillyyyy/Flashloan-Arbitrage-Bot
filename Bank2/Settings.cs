using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;

namespace Bank2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbTheme.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Theme");
            }
            else if (cbTheme.SelectedIndex == 0)
            {
                panel1.BackColor = Color.White;
            }
            else if (cbTheme.SelectedIndex == 1)
            {
                panel1.BackColor = Color.Blue;
            }
            else
            {
                panel1.BackColor = Color.Red;
            }
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=bank;username=root;password=;");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewpass.Text == "")
            {
                MessageBox.Show("Enter new password");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE admintable SET accpass = @APS WHERE acc_id = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@APS", txtNewpass.Text);
                    cmd.Parameters.AddWithValue("@ID", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password has been Updated");
                    con.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    }


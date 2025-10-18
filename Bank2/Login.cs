using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank2
{
    public partial class Login : Form
    {
        public static string id;
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=bank;username=root;password=;");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbRole.Items.Add("admin");
            cbRole.Items.Add("agent");

            if (cbRole.Items.Contains("admin"))
            {
                cbRole.SelectedIndex = cbRole.Items.IndexOf("admin");
            }
            else
            {
                cbRole.SelectedIndex = 0;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select Role");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                con.Open();
                if (cbRole.Text == "admin")
                {
                    AuthenticateAdmin(username, password);
                }
                else
                {
                    AuthenticateAgent(username, password);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void AuthenticateAdmin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM admintable WHERE admname=@username AND admpass=@password";
            using (MySqlCommand command = new MySqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    Agents obj = new Agents();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Admin username or Password");
                }
            }
        }

        private void AuthenticateAgent(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM agenttable WHERE accname=@username AND accpass=@password";
            using (MySqlCommand command = new MySqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    MainMenu obj = new MainMenu();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Agent username or Password");
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbRole.SelectedIndex = -1;
            cbRole.Text = "Role";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}

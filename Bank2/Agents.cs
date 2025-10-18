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
using MySql.Data.EntityFramework;
using MySql.Data.EntityFrameworkCore;

namespace Bank2
{
    public partial class Agents : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=bank;username=root;password=;");
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AgentDGV.Rows[e.RowIndex];

                txtName.Text = row.Cells["accname"].Value.ToString();
                txtPassword.Text = row.Cells["accpass"].Value.ToString();
                txtAddress.Text = row.Cells["accaddress"].Value.ToString();
                txtPhone.Text = row.Cells["accphone"].Value.ToString();
            }
        }
        private void DisplayAgents()
        {
            try
            {
                con.Open();
                string Query = "SELECT * FROM agenttable";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                AgentDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO agenttable(accname, accpass, accphone, accaddress) VALUES(@AN, @APS, @AP, @AA)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@AN", txtName.Text);
                    cmd.Parameters.AddWithValue("@APS", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@AP", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAddress.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Added");
                    Reset();
                    DisplayAgents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int selected = AgentDGV.SelectedRows[0].Index;
                int id = Convert.ToInt32(AgentDGV.Rows[selected].Cells["acc_id"].Value);
                string query = "UPDATE agenttable SET accname = @AN, accpass = @APS, accphone = @AP, accaddress = @AA WHERE acc_id = @ID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AN", txtName.Text);
                cmd.Parameters.AddWithValue("@APS", txtPassword.Text);
                cmd.Parameters.AddWithValue("@AP", txtPhone.Text);
                cmd.Parameters.AddWithValue("@AA", txtAddress.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row has been Updated.");
                DisplayAgents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show("Delete this Row?", "Confirmation", MessageBoxButtons.YesNo);

            if (Confirmation == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    if (AgentDGV.SelectedRows.Count > 0)
                    {
                        int selected = AgentDGV.SelectedRows[0].Index;
                        int id = Convert.ToInt32(AgentDGV.Rows[selected].Cells["acc_id"].Value);
                        string query = "DELETE FROM agenttable WHERE acc_id = @ID";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        int rowsaffected = cmd.ExecuteNonQuery();

                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Row Delete Successfully!");
                            DisplayAgents();
                        }
                        else
                        {
                            MessageBox.Show("Error Delete Row.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a Row to Delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void Reset()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void AgentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AgentDGV.Rows[e.RowIndex];

                txtName.Text = row.Cells["accname"].Value.ToString();
                txtPassword.Text = row.Cells["accpass"].Value.ToString();
                txtPhone.Text = row.Cells["accphone"].Value.ToString();
                txtAddress.Text = row.Cells["accaddress"].Value.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplayAgents();
        }
    }
}

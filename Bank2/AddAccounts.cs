using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank2
{
    public partial class AddAccounts : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=bank;username=root;password=;");

        public AddAccounts()
        {
            InitializeComponent();
            DisplayAccounts();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AccountDGV.Rows[e.RowIndex];

                txtName.Text = row.Cells["accname"].Value.ToString();
                txtPhone.Text = row.Cells["accphone"].Value.ToString();
                txtAddress.Text = row.Cells["accaddress"].Value.ToString();
                cbGender.Text = row.Cells["accgender"].Value.ToString();
                txtOccupation.Text = row.Cells["accoccup"].Value.ToString();
                cbEducation.Text = row.Cells["acceduc"].Value.ToString();
                txtIncome.Text = row.Cells["accinco"].Value.ToString();
            }
        }

        private void DisplayAccounts()
        {
            try
            {
                con.Open();
                string Query = "SELECT * FROM accounttable";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                AccountDGV.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(cbGender.Text) || string.IsNullOrWhiteSpace(txtOccupation.Text) || string.IsNullOrWhiteSpace(cbEducation.Text) || string.IsNullOrWhiteSpace(txtIncome.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO accounttable(accname, accphone, accaddress, accgender, accoccup, acceduc, accinco, accbal) VALUES(@AN, @AP, @AA, @AG, @AO, @AE, @AI, @AB)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@AN", txtName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@AG", cbGender.Text);
                    cmd.Parameters.AddWithValue("@AO", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@AE", cbEducation.Text);
                    cmd.Parameters.AddWithValue("@AI", txtIncome.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created");
                    Reset();
                    DisplayAccounts();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int selected = AccountDGV.SelectedRows[0].Index;
                int id = Convert.ToInt32(AccountDGV.Rows[selected].Cells["accnum"].Value);
                string query = "UPDATE accounttable SET accname = @AC, accphone = @AP, accaddress = @AD, accgender = @AG, accoccup = @AO, acceduc = @AE, accinco = @AI WHERE accnum = @ID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AC", txtName.Text);
                cmd.Parameters.AddWithValue("@AP", txtPhone.Text);
                cmd.Parameters.AddWithValue("@AD", txtAddress.Text);
                cmd.Parameters.AddWithValue("@AG", cbGender.Text);
                cmd.Parameters.AddWithValue("@AO", txtOccupation.Text);
                cmd.Parameters.AddWithValue("@AE", cbEducation.Text);
                cmd.Parameters.AddWithValue("@AI", txtIncome.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row has been Updated.");
                DisplayAccounts();
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
                    if (AccountDGV.SelectedRows.Count > 0)
                    {
                        int selected = AccountDGV.SelectedRows[0].Index;
                        int id = Convert.ToInt32(AccountDGV.Rows[selected].Cells["accnum"].Value);
                        string query = "DELETE FROM accounttable WHERE accnum = @ID";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        int rowsaffected = cmd.ExecuteNonQuery();

                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Row Delete Successfully!");
                            DisplayAccounts();
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
            txtPhone.Text = "";
            txtAddress.Text = "";
            cbGender.Text = "";
            txtOccupation.Text = "";
            cbEducation.Text = "";
            txtIncome.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu back = new MainMenu();
            back.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplayAccounts();
        }
    }
}

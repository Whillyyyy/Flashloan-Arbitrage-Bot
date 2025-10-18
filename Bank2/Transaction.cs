using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;

namespace Bank2
{
    public partial class Transaction : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;database=bank;username=root;password=;");
        private int Balance;

        public Transaction()
        {
            InitializeComponent();
        }

        private void CheckBalance()
        {
            try
            {
                con.Open();
                string query = "SELECT accbal FROM accounttable WHERE accnum=@accnum";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accnum", tbBalance.Text);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Balance = Convert.ToInt32(result);
                    blBalance.Text = "Peso" + Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Account not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void CheckAvailableBalance()
        {
            string query = "SELECT * FROM accounttable WHERE accnum = '" + txtFrom.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                BalanceLabel.Text = "Peso " + dr["accbal"].ToString();
                blBalance.Text = "Peso " + dr["accbal"].ToString();
            }
            else
            {
                BalanceLabel.Text = "No balance found for this account";
                blBalance.Text = "";
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            CheckAvailableBalance();
        }


        private void Deposit()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO transactiontable (trname,trdate,tramount,traccnum) VALUES (@TN,@TD,@TA,@TAN)", con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", Convert.ToInt32(tbDepoamount.Text));
                cmd.Parameters.AddWithValue("@TAN", tbDepoacc.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Money Deposited");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Withdraw()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO transactiontable (trname,trdate,tramount,traccnum) VALUES (@TN,@TD,@TA,@TAN)", con);
                cmd.Parameters.AddWithValue("@TN", "Withdraw");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", Convert.ToInt32(txtWithamount.Text));
                cmd.Parameters.AddWithValue("@TAN", txtWithacc.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Money Withdrawn");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBalance.Text))
            {
                MessageBox.Show("Enter Account Number");
            }
            else
            {
                CheckBalance();
            }
        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDepoacc.Text) || string.IsNullOrEmpty(tbDepoamount.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            Deposit();
            GetNewBalance();
            int newBal = Balance + Convert.ToInt32(tbDepoamount.Text);
            UpdateBalance(tbDepoacc.Text, newBal);
            tbDepoamount.Text = "";
            tbDepoacc.Text = "";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWithacc.Text) || string.IsNullOrEmpty(txtWithamount.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            GetNewBalance();
            if (Balance < Convert.ToInt32(txtWithamount.Text))
            {
                MessageBox.Show("Insufficient Balance");
                return;
            }

            Withdraw();
            int newBal = Balance - Convert.ToInt32(txtWithamount.Text);
            UpdateBalance(txtWithacc.Text, newBal);
            txtWithacc.Text = "";
            txtWithamount.Text = "";
        }

        private void GetNewBalance()
        {
            try
            {
                con.Open();
                string query = "SELECT accbal FROM accounttable WHERE accnum=@accnum";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accnum", tbBalance.Text);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Balance = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void UpdateBalance(string accountId, int newBalance)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE accounttable SET accbal=@newBal WHERE accnum=@accId", con);
                cmd.Parameters.AddWithValue("@newBal", newBalance);
                cmd.Parameters.AddWithValue("@accId", accountId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Balance Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void txtWithacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "")
            {
                MessageBox.Show("Enter user id");
            }
            else
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from accounttable where accnum='" + txtFrom.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalance();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Account id does not exist");
                    txtFrom.Text = "";
                }
                con.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtTo.Text == "")
            {
                MessageBox.Show("Enter Destination Account");
            }
            else
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from accounttable where accnum='" + txtTo.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //CheckAvailableBalance();
                    MessageBox.Show("Account found");
                    con.Close();
                    if (txtTo.Text == txtFrom.Text)
                    {
                        MessageBox.Show("ID and Destination are same");
                        txtTo.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Account id does not exist");
                    txtTo.Text = "";
                }
                con.Close();
            }
        }
        private void Transfer()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO transfertable (tfsrc,tfdest,tfamount,tfdate) VALUES (@TS,@TD,@TA,@TFN)", con);
                cmd.Parameters.AddWithValue("@TS", txtFrom.Text);
                cmd.Parameters.AddWithValue("@TD", txtTo.Text);
                cmd.Parameters.AddWithValue("@TA", txtTrAmount);
                cmd.Parameters.AddWithValue("@TFN", DateTime.Now.Date);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Money has been Transfered");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtFrom.Text) || string.IsNullOrEmpty(txtTrAmount.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int accnum;
                if (!int.TryParse(txtTo.Text, out accnum))
                {
                    MessageBox.Show("Invalid recipient account ID");
                    return;
                }

                if (Convert.ToInt32(txtTrAmount.Text) > Balance)
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    Transfer(accnum);
                }
            }
        }
        private void Transfer(int recipientAccountId)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=bank;username=root;password=;");

            try
            {
                con.Open();
                string deductQuery = "UPDATE accounttable SET accbal = accbal - @AT WHERE accnum = @ID";
                MySqlCommand deductCmd = new MySqlCommand(deductQuery, con);
                deductCmd.Parameters.AddWithValue("@AT", Convert.ToInt32(txtTrAmount.Text));
                deductCmd.Parameters.AddWithValue("@ID", txtFrom.Text);
                int rowsAffected = deductCmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Failed to deduct amount from sender's account");
                    return;
                }
                string addQuery = "UPDATE accounttable SET accbal = accbal + @AT WHERE accnum = @ID";
                MySqlCommand addCmd = new MySqlCommand(addQuery, con);
                addCmd.Parameters.AddWithValue("@AT", Convert.ToInt32(txtTrAmount.Text));
                addCmd.Parameters.AddWithValue("@ID", recipientAccountId);
                rowsAffected = addCmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Failed to add amount to recipient's account");
                    return;
                }
                MessageBox.Show("Transfer successful");
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu back = new MainMenu();
            back.Show();
        }
    }
}

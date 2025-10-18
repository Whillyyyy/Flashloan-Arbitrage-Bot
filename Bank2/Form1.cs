namespace Bank2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 10; 

            Myprogress.Value = startP;
            if (startP >= 100)
            {
                startP = 0;
                Myprogress.Value = 0;
                timer1.Stop();

                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
        }

    }
}
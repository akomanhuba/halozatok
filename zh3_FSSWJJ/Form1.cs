namespace zh3_FSSWJJ
{
    public partial class Form1 : Form
    {
        Models.TextbookSupportContext context = new Models.TextbookSupportContext();
        public Form1()
        {
            InitializeComponent();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill; 
        }

        private void button2_touc2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc2 = new UserControl2();
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
        }

        private void button3_tofrom2_Click(object sender, EventArgs e)
        {
            Form2 hozzaform = new Form2();
            if (hozzaform.ShowDialog() == DialogResult.OK)

            {

            }
        }

        private void button4_exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Biztos beakarod zárni az alkalmazást?", "Alkalmazás bezárása", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
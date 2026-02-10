namespace Project_8
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        public static string fname;
        public static string lname;
        public static string emailaddress;

        public static Boolean sms;
        public static Boolean Reports;
        public static Boolean transectioreport;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNSIGNUP_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            lname = textBox2.Text;
            emailaddress = textBox3.Text;
            this.Hide();
            confirmation c1 = new confirmation();
            c1.Show();
        }

        private void chksms_CheckedChanged(object sender, EventArgs e)
        {
            if (chksms.Checked)
            {
                sms = true;
                label4.Text = "service may be change after sms";
            }
            else
            {
                sms = false;
                label6.Text = "------";
            }
        }

        private void chktransectionreport_CheckedChanged(object sender, EventArgs e)
        {
            if (chktransectionreport.Checked)
            {
                transectioreport = true;
                label4.Text = "transection report may be share with you";
            }
            else
            {
                transectioreport = false;
                label6.Text = "------";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void chkreport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkreport.Checked)
            {
                Reports = true;
                label4.Text = "service may be change after sms";
            }
            else
            {
                Reports = false;
                label6.Text = "------";
            }
        }
    }
}

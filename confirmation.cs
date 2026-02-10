using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_8
{
    public partial class confirmation : Form
    {
        public confirmation()
        {
            InitializeComponent();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void confirmation_Load(object sender, EventArgs e)
        {
            lblfname.Text = signup.fname;
            lbllname.Text = signup.lname;
            lblemailaddress.Text = signup.emailaddress;
            //lblsms.Text=Form1.sms.ToString();
            string services = "";

            if (signup.sms)
                services += "SMS, ";

            if (signup.Reports)
                services += "Reports, ";

            if (signup.transectioreport)
                services += "Transaction Report, ";

            if (services.EndsWith(", "))
                services = services.Substring(0, services.Length - 2);

            lblservices.Text = services;
        }
    }
}

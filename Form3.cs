using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassportApplication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblGuardianName.Text = Form1.guardianName;
            lblGuardianHome.Text = Form1.guardianHomeAddress;
            //lblGuardianPhone.Text = Form1.guardianPhone;
            lblPassportNo.Text = Form1.oldPassportNo;
            lblPassportIssueDate.Text = Form1.passportIssueDate;
            lblPassportExpiryDate.Text = Form1.passportExpiryDate;

            if (Form1.Ordinary)
            {
                lblPassportType.Text = "Ordinary";
            }

            if (Form1.International)
            {
                lblPassportType.Text = "International";
            }

            if (Form1.Diplomatic)
            {
                lblPassportType.Text = "Diplomatic";
            }

            if (Form1.Yes)
            {
                lblFirstPassport.Text = "Yes";
                lblExpiryDate.Text = "";
                lblExpiredPassportNo.Text = "";
                lblPassportExpiryDate.Text = "";
                lblIssueDate.Text = "";
                lblPassportIssueDate.Text = "";
            }

            if (Form1.No)
            {
                lblFirstPassport.Text = "No"; 
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}

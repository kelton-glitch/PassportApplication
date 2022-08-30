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
    public partial class Form1 : Form
    {

        //public static string firstName, middleName, lastName, emailAddress, homeAddress, Occupation , destinationCountry , guardianName, guardianHomeAddress, oldPassportNo, passportIssueDate, passportExpiryDate;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure want to proceed?","PASSCAM",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information
                );

            if (dr == DialogResult.Yes)
            {

            }

            if (dr == DialogResult.No)
            {

            }
        }

        private void dTPickerPassportIssueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dTPickerPassportIssueDate.Value;
            dTPickerPassportExpiryDate.MinDate = dt;
        }
    }
}
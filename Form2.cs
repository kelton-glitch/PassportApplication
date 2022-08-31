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
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = Form1.firstName;
            lblMiddleName.Text = Form1.middleName;
            lblLastName.Text = Form1.lastName;
            lblEmailAddress.Text = Form1.emailAddress;
            lblDateOfBirth.Text = Form1.dateOfBirth;
            lblPhoneNumber.Text = Form1.phoneNumber.ToString();
            lblHomeAddress.Text = Form1.homeAddress;
            lblOccupation.Text = Form1.Occupation;
            lblDestination.Text = Form1.destinationCountry;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

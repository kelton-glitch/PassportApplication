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
        public static Boolean Yes, No, Ordinary, Diplomatic, International;
        public static string firstName, middleName, lastName, emailAddress, homeAddress, Occupation ,dateOfBirth, destinationCountry , guardianName, guardianHomeAddress, oldPassportNo, passportIssueDate, passportExpiryDate;
        public static int phoneNumber, guardianPhone;
        private void rdbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYes.Checked)
            {
                lblNumber.Enabled = false;
                txtExpiredPassport.Enabled = false;
                lblIssue.Enabled = false;
                dTPickerPassportIssueDate.Enabled = false;
                lblExpiry.Enabled = false;
                dTPickerPassportExpiryDate.Enabled = false;
            }
            Yes = true;
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNo.Checked)
            {
                lblNumber.Enabled = true;
                txtExpiredPassport.Enabled = true;
                lblIssue.Enabled = true;
                dTPickerPassportIssueDate.Enabled = true;
                lblExpiry.Enabled = true;
                dTPickerPassportExpiryDate.Enabled = true;
            }
           
            No = true;
        }

        private void rdbInternational_CheckedChanged(object sender, EventArgs e)
        {
            International = true;
        }

        private void rdbDiplomatic_CheckedChanged(object sender, EventArgs e)
        {
            Diplomatic = true;
        }

        private void rdbOrdinary_CheckedChanged(object sender, EventArgs e)
        {
            Ordinary = true;
        }

       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure want to proceed?", "PASSCAM",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information
                );

            if (dr == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtfirstName.Text)) 
                   {
                    MessageBox.Show("Please enter First name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                   }

                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show("Please enter Last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rdbNo.Checked)
                {
                    if (string.IsNullOrEmpty(txtExpiredPassport.Text))
                    {
                        MessageBox.Show("Please enter Passport Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                /// In case of implementing a class using a database
                /*
                Person person = new Person();
                person.FirstName = txtfirstName.Text;
                person.MiddleName = txtMiddleName.Text;
                person.LastName = txtLastName.Text;
                person.Destination = txtDestination.Text;
                person.Occupation = txtOccupation.Text;
                person.DateOfBirth = dateTimePicker1.Value.ToString("dd MMM yyyy");
                person.EmailAddress = txtEmailAddress.Text;
                person.HomeAddress = txtHomeAddress.Text;
                person.PhoneNumber = int.Parse(txtPhoneNumber.Text);
                */

                firstName = txtfirstName.Text;
                middleName = txtMiddleName.Text;
                lastName = txtLastName.Text;
                destinationCountry = txtDestination.Text;
                Occupation = txtOccupation.Text;
                dateOfBirth = dateTimePicker1.Value.ToString("dd MMM yyyy");
                emailAddress = txtEmailAddress.Text;
                homeAddress = txtHomeAddress.Text;
                phoneNumber = int.Parse(txtPhoneNumber.Text);


                guardianName = txtGuardianName.Text;
                guardianHomeAddress = txtGuardianHome.Text;
                guardianPhone = int.Parse(txtGuardianPhone.Text);

                oldPassportNo = txtExpiredPassport.Text;
                passportIssueDate = dTPickerPassportIssueDate.Value.ToString("dd MMM yyyy");
                passportExpiryDate = dTPickerPassportExpiryDate.Value.ToString("dd MMM yyyy");
                

                this.Hide();
               
                Form2 form2 = new Form2();
               

                Form3 form3 = new Form3();
                form3.Show();
                form2.Show();

            }

            if (dr == DialogResult.No)
            {
                return;
            }
        }

        private void dTPickerPassportIssueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dTPickerPassportIssueDate.Value;
            dTPickerPassportExpiryDate.MinDate = dt;
        }
    }
}
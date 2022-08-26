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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inizialtion_of_varibles
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }

        private void btncdisplay_Click(object sender, EventArgs e)
        {
            string firstname;
            string lastname;

            firstname = txtFname.Text;
            lastname = txtLname.Text;

            MessageBox.Show(firstname);
            MessageBox.Show(lastname);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           
        }
    }
}


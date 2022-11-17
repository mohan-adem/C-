using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statement
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }

        private void btncheking_Click(object sender, EventArgs e)
        {
            string name;
            name = txtcheking.Text;
            if (name == "ali")
            {
                MessageBox.Show("Hello mr." + name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voating
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }

        private void btnvoating_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(txtAged.Text);
            if (age > 15)
            {
                MessageBox.Show("waad codeeen kartaa");
            }
        }
    }
}

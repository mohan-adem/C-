using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forech_loop
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
            int[] intarray = new int[5] { 10, 20, 30, 40, 50, };
            foreach (var i in intarray)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}

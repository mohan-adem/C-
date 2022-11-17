using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_loop
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            int number = 0;
            while (number <= 10)
            {
                lstoutput.Items.Add(number);
                number++;
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lstoutput.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmdemo_Load(object sender, EventArgs e)
        {
        
        }
    }
}

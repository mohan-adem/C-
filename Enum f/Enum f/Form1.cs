using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_f
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }
        enum Temperature
        {
            low,
            medium,
            high,
        }

        private void btnenum_Click(object sender, EventArgs e)
        {
            Temperature value = Temperature.medium;
            if (value == Temperature.medium)
            {
                MessageBox.Show("Tempureture is medium..");
            }
        }
    }
}

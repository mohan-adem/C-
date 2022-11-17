using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop_enum
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }
        public enum colors
        {
            Red,
            Green,
            Blue,
        }
        private void btnloopenum_Click(object sender, EventArgs e)
        {
            foreach (colors icolor in Enum.(typeof(colors)))
            {
                MessageBox.Show(icolor.ToString());
            }
        }
    }
}

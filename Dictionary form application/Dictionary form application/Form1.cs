using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_form_application
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var my_Dictionary = new Dictionary<string, string>()
            {
                //word       //meaning
                {"Accuse",  "to say that something has done something wrong."},
                {"Apparent",  "Easy to see or understand."},
                {"Fatigue",  "Extreme tirdness."},
                {"obesity",  "Extremely fat."},
                {"Medicinal",  "That which heals, cures."},
                {"Cancer",  "An illness that damages in the body speacilly headch and other body."},
                {"Addiction",  "Astrong desires to use something."},
                {"Abuse",  "To use something wrongly."},
                {"Elevation",  "Haigh place."},
              };
            string word;
            word = inputBox.Text;
            try
            {
                resultBox.Text = my_Dictionary[word];
            }
            catch
            {

                resultBox.Text = "Waa ka xunahay! lama helin kalmadaas";
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

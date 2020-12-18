using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreverse_Click(object sender, EventArgs e)
        {
            if (txtinput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu", "Error");
            }
            else
            {
                string a = txtinput.Text;
                char[] b = txtinput.Text.ToArray();
                Array.Reverse(b);
                a = new string(b);
                lbloutput.Text = a;
            }





        }

        private void btnurutkan_Click(object sender, EventArgs e)
        {
            if (txtinput.Text == "")
            {

                MessageBox.Show("Tolong isi textbox terlebih dahulu", "Error");
            }
            else
            {
                lbloutput.Text = txtinput.Text;
            }
        }
    }
}

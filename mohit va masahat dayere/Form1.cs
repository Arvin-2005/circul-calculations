using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mohit_va_masahat_dayere
{
    public partial class mohitmasahat : Form
    {
        private const float pi = 3.14f;
        public mohitmasahat()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int myradius;
            myradius = int.Parse(textBox1.Text);
            float myresult;
            myresult = pi * myradius * myradius;
            MessageBox.Show(myresult.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int myradius;
            myradius = int.Parse(textBox1.Text);
            float myresult;
            myresult = 2*pi*myradius;
            MessageBox.Show(myresult.ToString());
        }
    }
}

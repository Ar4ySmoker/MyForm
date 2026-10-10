using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

          

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) // Allow only numbers and backspace
            {
                e.Handled = true;
            }
            if ((textBox1.Text.Contains(',') == true) & (number == 44))
                {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double numb = 0.0;
            numb = Convert.ToDouble(textBox1.Text);

            if(checkBox1.Checked == true)
            {
                numb = numb / 2.54;
            }
            else
            {
                numb = numb * 2.54;
            }
            label2.Text = numb.ToString();
            
        }
    }
}

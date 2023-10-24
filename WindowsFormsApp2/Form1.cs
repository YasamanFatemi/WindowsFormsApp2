using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int i;
        int j;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox2.Text);
            if (i <= 20)
            {
                listBox1.Items.Add(number);

                i++;
                j = j + number;
                int sum = (j / i);
                label1.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("20 nafar shod");
            }
        }
    }
}

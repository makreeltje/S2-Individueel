using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzels___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int i;
            int j = 0;
            int number = 43;

            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;

                if (n3 % 2 == 0)
                {
                    listBox1.Items.Add(n3);
                }
                
                n1 = n2;
                n2 = n3;
            }

            foreach (int item in listBox1.Items)
            {
                j = j + item;
            }

            label1.Text = j.ToString();
        }
    }
}

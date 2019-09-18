using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzels___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = 3; i < 1000; i = i + 3)
            {
                listBox1.Items.Add(i);
            }

            for (int i = 5; i < 1000; i = i + 5)
            {
                listBox1.Items.Add(i);
            }

            int j = 0;

            foreach (int item in listBox1.Items)
            {
                j = j + item;
            }

            label1.Text = j.ToString();

        }
    }
}

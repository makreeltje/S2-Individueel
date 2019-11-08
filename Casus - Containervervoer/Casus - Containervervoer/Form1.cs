using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casus___Containervervoer
{
    public partial class Form1 : Form
    {
        Ship Ships = new Ship();
        public List<Container> Containers = new List<Container>();
        public Container con;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContainerToList_Click(object sender, EventArgs e)
        {
            string name = txtContainerName.Text;
            con.Category cat;
            con.Weight weight;

        }
    }
}

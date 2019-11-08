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
        private readonly List<Container> _containers;
        private Ship ship;
        public Form1()
        {
            _containers = new List<Container>();
            InitializeComponent();
        }

        private void btnAddContainer_Click(object sender, System.EventArgs e)
        {
            int weight = (int)numContainerWeight.Value;
            Container.Categories cat;

            if (rbContainerCooled.Checked) { cat = Casus___Containervervoer.Container.Categories.Cooled; }
            else if (rbContainerValuable.Checked) { cat = Casus___Containervervoer.Container.Categories.Valuable; }
            else { cat = Casus___Containervervoer.Container.Categories.Standard; }

            var container = new Container(cat, weight);

            _containers.Add(container);

            listContainers.Items.Add(container);

            lblContainerTotal.Text = listContainers.Items.Count.ToString();

        }

        private void btnSetShipWeight_Click(object sender, System.EventArgs e)
        {
            ship = new Ship((int)numShipWeight.Value);
            btnSetShipWeight.Enabled = false;
            btnAddContainer.Enabled = true;
        }
    }
}

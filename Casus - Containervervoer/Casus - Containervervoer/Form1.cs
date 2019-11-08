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

            if (numContainerWeight.Value >= 4000 && numContainerWeight.Value <= 30000)
            {
                if (rbContainerCooled.Checked) { cat = Casus___Containervervoer.Container.Categories.Cooled; }
                else if (rbContainerValuable.Checked) { cat = Casus___Containervervoer.Container.Categories.Valuable; }
                else { cat = Casus___Containervervoer.Container.Categories.Standard; }

                var container = new Container(cat, weight);

                _containers.Add(container);

                listContainers.Items.Add(container);

                rtbLog.ForeColor = Color.Green;
                rtbLog.Text = $"Container ({container}) has been added succesfully";

                lblContainerTotal.Text = listContainers.Items.Count.ToString();
            }
            else
            {
                rtbLog.ForeColor = Color.Red;
                if (numContainerWeight.Value < 4000)
                {
                    
                    rtbLog.Text =
                        $"Sorry but the weight of the container you're trying to add is too low. The weight needs to be between 4 and 30 tons. The current weight of the container is {numContainerWeight.Value / 1000} tons. ";
                }
                else
                {
                    rtbLog.Text = $"Sorry but the weight of the container you're trying to add is too high. The weight needs to be between 4 and 30 tons. The current weight of the container is {numContainerWeight.Value / 1000} tons. ";
                }
            }

        }

        private void btnSetShipWeight_Click(object sender, System.EventArgs e)
        {
            ship = new Ship((int)numShipWeight.Value);
            btnSetShipWeight.Enabled = false;
            btnAddContainer.Enabled = true;
        }
    }
}

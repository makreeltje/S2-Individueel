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
using System.IO;

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
            int totalWeight = 0;

            if (numContainerWeight.Value >= 4000 && numContainerWeight.Value <= 30000)
            {
                _containers.Add(container);

                listContainers.Items.Add(container);

                rtbLog.ForeColor = Color.Green;
                rtbLog.Text = $"Container ({container}) has been added succesfully";

                lblContainerTotal.Text = listContainers.Items.Count.ToString();

                if (!container.CheckTotalWeightContainer(ship.Weight, _containers))
                {
                    rtbLog.ForeColor = Color.Red;
                    rtbLog.Text = $"The total weight of the containers exceeds the weight of the ship. Please remove a container to continue";
                }

                foreach (var item in _containers)
                {
                    totalWeight += item.Weight;
                }

                totalWeight = totalWeight / 1000;

                lblContainerWeight.Text = $"{totalWeight} tons";
            }
            else
            { 
                rtbLog.ForeColor = Color.Red;
                rtbLog.Text = container.CheckWeightContainer(weight);
            }

        }

        private void btnSetShipWeight_Click(object sender, System.EventArgs e)
        {
            ship = new Ship((int)numShipWeight.Value);
            btnSetShipWeight.Enabled = false;
            btnAddContainer.Enabled = true;
            rtbLog.ForeColor = Color.Green;
            rtbLog.Text = $"The weight of the ship has been set to {ship.Weight / 1000} tons";
            lblShipWeight.Text = $"{ship.Weight / 1000} tons";
        }

        private void btnContainerDelete_Click(object sender, EventArgs e)
        {
            int index = listContainers.SelectedIndex;

            if (index == -1)
            {
                rtbLog.ForeColor = Color.Red;
                rtbLog.Text = "No container has been selected";
                return;
            }

            rtbLog.ForeColor = Color.Green;
            rtbLog.Text = $"Container ({listContainers.SelectedItem}) has been removed succesfully";
            listContainers.Items.RemoveAt(index);
            _containers.RemoveAt(index);
            lblContainerTotal.Text = listContainers.Items.Count.ToString();
        }

        private void btnContainerDeleteAll_Click(object sender, EventArgs e)
        {
            listContainers.Items.Clear();
            _containers.Clear();
            rtbLog.ForeColor = Color.Green;
            rtbLog.Text = $"All containers have been removed";
            lblContainerTotal.Text = "No containers added";

        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {

        }
    }
}

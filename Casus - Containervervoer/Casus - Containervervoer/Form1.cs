using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Classes;
using Container = Classes.Container;

namespace Casus___Containervervoer
{
    public partial class Form1 : Form
    {
        private readonly List<Container> _containers;
        private Ship _ship;
        
        public Form1()
        {
            _containers = new List<Container>();
            InitializeComponent();
        }

        private void BtnAddContainer_Click(object sender, System.EventArgs e)
        {
            int weight = (int)numContainerWeight.Value;
            Container.Categories cat;

            if (checkCooled.Checked && checkValuable.Checked) { cat = Classes.Container.Categories.ValuableCooled; }
            else if (checkValuable.Checked) { cat = Classes.Container.Categories.Valuable; }
            else if (checkCooled.Checked ){ cat = Classes.Container.Categories.Cooled; }
            else { cat = Classes.Container.Categories.Normal; }

            var container = new Container(cat, weight);

            if (!container.CheckWeightContainer((int)numContainerWeight.Value))
            {
                _containers.Add(container);

                listContainers.Items.Add(container);

                rtbLog.ForeColor = Color.Green;
                rtbLog.Text = $"Container ({container}) has been added succesfully";

                lblContainerTotal.Text = listContainers.Items.Count.ToString();

                int totalWeight = TotalWeight();
                if (totalWeight >= _ship.MinWeight)
                {
                    if (!container.CheckTotalWeightContainer(_ship.MinWeight, _ship.MaxWeight, _containers))
                    {
                        rtbLog.ForeColor = Color.Red;
                        rtbLog.Text = $"The total weight of the containers exceeds the weight of the ship. Please remove a container to continue";
                    }
                }
                
                lblContainerWeight.Text = $"{totalWeight} tons";
            }
            else
            {
                rtbLog.ForeColor = Color.Red;
                rtbLog.Text = $"Sorry but the weight of the container you're trying to add is not correct. The weight needs to be between 4 and 30 tons. The current weight of the container is {weight} tons. ";
            }
            File.AppendAllText("log.txt", $"[{DateTime.Now.ToString()}]: {rtbLog.Text}\n");

        }

        private void BtnSetShipWeight_Click(object sender, System.EventArgs e)
        {
            if (numLength.Value <= 0 || numWidth.Value <= 0)
            {
                rtbLog.ForeColor = Color.Red;
                rtbLog.Text =
                    $"Sorry, but the ship must be at least 1 wide and 1 long. Currently you have set the following values:\n" +
                    $"- Length:\t\t {numLength.Value} \n" +
                    $"- Width:\t\t {numWidth.Value}";
                File.AppendAllText("log.txt", $"[{DateTime.Now.ToString()}]: {rtbLog.Text}\n");
                return;
            }
            _ship = new Ship((int)numLength.Value, (int)numWidth.Value);
            _ship.CreateRows(_ship.Lenght, _ship.Width);
            btnSetShipWeight.Enabled = false;
            btnAddContainer.Enabled = true;
            rtbLog.ForeColor = Color.Green;
            rtbLog.Text = $"The Values of the ship has been set \n" +
                          $"- Ship Length:\t{_ship.Lenght}\n" +
                          $"- Ship Width:\t{_ship.Width}\n" +
                          $"- Max Weight:\t{_ship.MaxWeight}\n" +
                          $"- Min Weight:\t{_ship.MinWeight}";
            File.AppendAllText("log.txt", $"[{DateTime.Now.ToString()}]: {rtbLog.Text}\n");
            lblShipLength.Text = _ship.Lenght.ToString();
            lblShipWidth.Text = _ship.Width.ToString();
            lblShipMaxWeight.Text = _ship.MaxWeight.ToString();
            lblShipMinWeight.Text = _ship.MinWeight.ToString();
        }

        private void BtnContainerDelete_Click(object sender, EventArgs e)
        {
            int index = listContainers.SelectedIndex;

            if (index == -1)
            {
                rtbLog.ForeColor = Color.Red;
                rtbLog.Text = "No container has been selected";
                File.AppendAllText("log.txt", $"[{DateTime.Now.ToString()}]: {rtbLog.Text}\n");
                return;
            }

            rtbLog.ForeColor = Color.Green;
            rtbLog.Text = $"Container ({listContainers.SelectedItem}) has been removed succesfully";
            File.AppendAllText("log.txt", $"[{DateTime.Now.ToString()}]: {rtbLog.Text}\n");
            listContainers.Items.RemoveAt(index);
            _containers.RemoveAt(index);
            lblContainerTotal.Text = listContainers.Items.Count.ToString();

            int totalWeight = TotalWeight();

            lblContainerWeight.Text = $"{totalWeight} tons";
        }

        private void BtnContainerDeleteAll_Click(object sender, EventArgs e)
        {
            listContainers.Items.Clear();
            _containers.Clear();
            rtbLog.ForeColor = Color.Green;
            rtbLog.Text = $"All containers have been removed";
            File.AppendAllText("log.txt", $"[{DateTime.Now.ToString()}]: {rtbLog.Text}\n");
            lblContainerTotal.Text = "No containers added";

        }

        private void BtnCalculation_Click(object sender, EventArgs e)
        {
            int totalWeight = TotalWeight();
            if (totalWeight < _ship.MinWeight)
            {
                rtbLog.ForeColor = Color.Red;
                rtbLog.Text =
                    $"The total weight of the containers is lower than the minimum threshold, add more containers to the ship: \n" +
                    $"- Total Weight:\t {totalWeight}";
            }
            else
            {
                _ship.ClearStacks();
                _ship.SortContainerByCategory(_containers);

                switch (_ship.AddContainerToStack(_ship.Width, _ship.Lenght))
                {
                    case 0:
                        rtbLog.ForeColor = Color.Red;
                        rtbLog.Text = "Too many valuable cooled containers";
                        break;
                    case 1:
                        rtbLog.ForeColor = Color.Red;
                        rtbLog.Text = "Too many cooled containers";
                        break;
                    case 3:
                        rtbLog.ForeColor = Color.Green;
                        rtbLog.Text = "Calculation has been made";
                        break;
                    case 4:
                        rtbLog.ForeColor = Color.Red;
                        rtbLog.Text = "Too many valuable containers";
                        break;
                }
                File.AppendAllText("log.txt", $"[{DateTime.Now.ToString()}]: {rtbLog.Text}\n");
                _ship.ReverseStacks();
                //shipVisualizer += alg.BuildVisualizer(_ship.Width, _ship.Lenght);

                foreach (var row in _ship.GetRows())
                {
                    listRows.Items.Add($"Row {row.Id}");
                }
            }
            //System.Diagnostics.Process.Start(shipVisualizer);
        }

        private int TotalWeight()
        {
            int totalWeight = 0;
            foreach (var item in _containers)
            {
                totalWeight += item.Weight;
            }

            return totalWeight;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            File.Open("log.txt", FileMode.Open);
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void ListRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStacks.Items.Clear();
            foreach (var stack in _ship.GetRows()[listRows.SelectedIndex].stacks)
            {
                listStacks.Items.Add($"Stack {stack.Id}");
            }
        }

        private void ListStacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContainer.Items.Clear();
            foreach (var container in _ship.GetRows()[listRows.SelectedIndex].stacks[listStacks.SelectedIndex].containers)
            {
                listContainer.Items.Add($"Category: {container.Category.ToString()} | Weight: {container.Weight} tons");
                
            }

            lblSelectedStackWeight.Text = _ship.GetRows()[listRows.SelectedIndex].stacks[listStacks.SelectedIndex].StackWeight
                .ToString();
        }

        private void ListContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedContainerCategory.Text = _ship.GetRows()[listRows.SelectedIndex].stacks[listStacks.SelectedIndex]
                .containers[listContainer.SelectedIndex].Category.ToString();
            lblSelectedContainerWeight.Text = _ship.GetRows()[listRows.SelectedIndex].stacks[listStacks.SelectedIndex]
                .containers[listContainer.SelectedIndex].Weight.ToString();
        }
    }
}

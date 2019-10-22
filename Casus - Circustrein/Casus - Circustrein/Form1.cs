using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casus___Circustrein
{
    public partial class Form1 : Form
    {
        readonly Train Trains = new Train();
        public List<Animal> AllAnimals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddAnimalAdd_Click(object sender, EventArgs e)
        {
            bool carnivore = RadCarnivore.Checked;
            Animal.Sizes size;

            if (RadBig.Checked)
            {
                size = Animal.Sizes.Big;
            }
            else if (RadMedium.Checked)
            {
                size = Animal.Sizes.Medium;
            }
            else
            {
                size = Animal.Sizes.Small;
            }

            string name = TbName.Text;

            Animal newAnimal = new Animal(size, carnivore, name);

            AllAnimals.Add(newAnimal);
            ListAnimal.Items.Add(newAnimal);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Trains.Wagons.Clear();
            Trains.FillWagon(AllAnimals);

            ListAnimal.Items.Clear();
            foreach (Animal item in AllAnimals)
            {
                ListAnimal.Items.Add(item);
            }
            ListTrain.Items.Clear();
            foreach (Wagon currentWagon in Trains.Wagons)
            {
                ListTrain.Items.Add(currentWagon);
            }
        }

        private void ListAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListAnimal.SelectedIndex;
            Animal selectedAnimal = AllAnimals[selectedIndex];

            LabelSelectedAnimal.Text = $"{selectedAnimal.Name}\n{selectedAnimal.Size}\n{selectedAnimal.getKind()}";
        }

        private void ListWagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedWagonIndex = ListTrain.SelectedIndex;
            int selectedAnimalIndex = ListWagon.SelectedIndex;

            Animal selectedAnimal = Trains.Wagons[selectedWagonIndex].Animals[selectedAnimalIndex];

            LabelSelectedAnimal.Text = $"{selectedAnimal.Name}\n{selectedAnimal.Size}\n{selectedAnimal.getKind()}";
        }

        private void ListTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListTrain.SelectedIndex;
            Wagon selectedWagon = Trains.Wagons[selectedIndex];

            ListWagon.Items.Clear();

            foreach (Animal wagonAnimal in selectedWagon.Animals)
            {
                ListWagon.Items.Add(wagonAnimal);
            }
        }
    }
}

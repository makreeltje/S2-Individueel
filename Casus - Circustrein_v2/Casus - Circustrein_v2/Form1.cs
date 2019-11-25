using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casus___Circustrein_v2
{
    public partial class Form1 : Form
    {
        private readonly Train Trains = new Train();
        private List<Animal> Animals = new List<Animal>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string name = TextName.Text;
            int i;
            Animal.Sizes size;
            Animal.Types type;

            if (RadioSmall.Checked) { size = Animal.Sizes.Small; }
            else if (RadioMedium.Checked) { size = Animal.Sizes.Medium; }
            else { size = Animal.Sizes.Big; }

            if (RadioCarnivore.Checked) { type = Animal.Types.Carnivore; }
            else { type = Animal.Types.Herbivore; }

            Animals.Add(new Animal(name, type, size));

            i = Animals.Count - 1;

            ListAnimals.Items.Add($"{Animals[i].Name} ({Animals[i].Size}, {Animals[i].Type})");

       
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Trains.ClearList();
            Trains.FillWagon(Animals);

            ListAnimals.Items.Clear();
            foreach (Animal item in Animals)
            {
                ListAnimals.Items.Add(item);
            }
            ListAnimals.Items.Clear();
            foreach (Wagon currentWagon in Trains.GetWagonsList())
            {
                ListTrains.Items.Add(currentWagon);
            }
        }

        private void ListTrains_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListTrains.SelectedIndex;
            Wagon selectedWagon = Trains.GetWagonsList()[selectedIndex];

            ListWagons.Items.Clear();

            foreach (Animal wagonAnimal in selectedWagon.GetAnimalsList())
            {
                ListWagons.Items.Add($"{wagonAnimal.Name} ({wagonAnimal.Size}, {wagonAnimal.Type})");
            }
        }
    }
}

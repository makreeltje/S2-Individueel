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
        public Form1()
        {
            InitializeComponent();

        }
        private List<Animal> Animals = new List<Animal>();
        private int i = 1;

        private void BtnAddAnimalAdd_Click(object sender, EventArgs e)
        {
            int category = 0;
            int diet = 0;

            if (RadSmall.Checked) { category = 1; }
            else if (RadMedium.Checked) { category = 2; }
            else { category = 3; }

            if (RadCarnivore.Checked) { diet = 1; }
            else { diet = 2; }
            
            Animals.Add(new Animal(i, TbName.Text, category, diet));
            listBox1.Items.Clear();
            foreach (Animal dier in Animals)
            {
                listBox1.Items.Add($"Name: {dier.Name} Eating: {dier.eating} AnimalID: {dier.AnimalID} Size: {dier.size} ");
            }

            i++;
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            GbAddAnimal.Visible = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        private List<Animal> animals = new List<Animal>();
        private int i = 1;
        Wagon wagons = new Wagon();

        private void BtnAddAnimalAdd_Click(object sender, EventArgs e)
        {
            int category;
            int diet;

            if (RadSmall.Checked) { category = 1; }
            else if (RadMedium.Checked) { category = 2; }
            else { category = 3; }

            if (RadCarnivore.Checked) { diet = 1; }
            else { diet = 2; }
            
            animals.Add(new Animal(i, TbName.Text, category, diet, false));
            listBox1.Items.Clear();
            foreach (Animal dier in animals)
            {
                listBox1.Items.Add($"Name: {dier.Name} Eating: {dier.eating} AnimalID: {dier.AnimalID} Size: {dier.size} ");
            }

            i++;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //while (animals.Count >= 0)
            //{
                foreach (Animal animal in animals)
                {
                    label5.Text = wagons.AddAnimalToWagon(animal.size, animal.eating).ToString();
                }
            //}

            //int size = 0;
            //foreach (var animal in animals)
            //{
            //    size += wagons.AddAnimalToWagon(animal.size, animal.eating);
            //}

            //size = size / 10;

            //label5.Text = size.ToString();
        }
    }
}

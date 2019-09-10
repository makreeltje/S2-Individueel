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
        private RadioButton selectedRadioButton;
        public Form1()
        {
            InitializeComponent();
            

        }
        //private List<Animal> animals = new List<Animal>();
        private int i = 1;
        Wagon wagons = new Wagon();

        private void ChangeSelectionRB(object sender, EventArgs e)
        {
            selectedRadioButton = (RadioButton) sender;
        }

        private void BtnAddAnimalAdd_Click(object sender, EventArgs e)
        {
            int category = 0;
            int diet;


            category = Convert.ToInt32(selectedRadioButton.Tag);
            MessageBox.Show(category.ToString());
            if (RadCarnivore.Checked) { diet = 1; }
            else { diet = 2; }
            
            

            Animal.list.Add(new Animal(TbName.Text, category, diet, false));
            listBox1.Items.Clear();
            foreach (Animal dier in Animal.list)
            {
                listBox1.Items.Add($"Name: {dier.Name} Eating: {dier.Eating} AnimalID: {dier.AnimalID} Size: {dier.Size} ");
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
                foreach (Animal animal in Animal.list)
                {
                    label5.Text = wagons.AddAnimalToWagon(animal.Size, animal.Eating).ToString();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManager.Business;

namespace Meerlaagse_Architectuur
{
    public partial class MainForm : Form
    {
        private List<Employee> _employees;
        private int _currentEmployeeIndex;

        public MainForm()
        {
            InitializeComponent();
            _employees = new List<Employee>();
            _currentEmployeeIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            DisplayEmployee(_currentEmployeeIndex);
        }

        private void DisplayEmployee(int counter)
        {
            Employee empToShow = _employees[counter];

            nameLabel.Text = empToShow.ToString();

            pNrTextBox.Text = empToShow.PersonnelNumber.ToString();
            firstNameTextBox.Text = empToShow.FirstName;
            lastNameTextBox.Text = empToShow.LastName;
            dobTextBox.Text = empToShow.DateOfBirth.ToString();
            startDateTextBox.Text = empToShow.StartDate.ToString();

           // photoPictureBox.Image = Image.FromFile(empToShow.ImageName);
        }

        private void LoadData()
        {
            // LoadDataFromFile();
            _employees = Employee.GetAllEmployees();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            _currentEmployeeIndex = Math.Max(0, --_currentEmployeeIndex);
            DisplayEmployee(_currentEmployeeIndex);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _currentEmployeeIndex = Math.Min(_employees.Count - 1, ++_currentEmployeeIndex);
            DisplayEmployee(_currentEmployeeIndex);
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Byeeeeeeeeeeee");
        }

        private void giveRaiseButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mo' money mo' problems!");
        }
    }
}

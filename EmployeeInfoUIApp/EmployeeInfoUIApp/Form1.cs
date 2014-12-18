using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        Employee aEmployee = new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            aEmployee.id = idTextBox.Text;
            aEmployee.name = nameTextBox.Text;
            aEmployee.salary = Convert.ToDouble(salaryTextBox.Text);

            MessageBox.Show("Employee Information"+"\n"+"ID : "+aEmployee.id +"\n"+"name : " + aEmployee.name + "\n" +"Salary : " +aEmployee.salary);
            idTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aEmployee.id;
            nameTextBox.Text = aEmployee.name;
            salaryTextBox.Text = aEmployee.salary.ToString();
        }
    }
}

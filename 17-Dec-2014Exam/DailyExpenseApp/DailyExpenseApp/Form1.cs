using CSVLib;
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

namespace DailyExpenseApp
{
    public partial class DailyExpenseUI : Form
    {
        public DailyExpenseUI()
        {
            InitializeComponent();
        }
        string path = @"F:\dailyExpense.csv";
        private void saveButton_Click(object sender, EventArgs e)
        {
            string amount = amountTextBox.Text;
            string category = categoryComboBox.Text;
            string particuler = particulerTextBox.Text;

            FileStream aFileStream = new FileStream(path, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
            List<string> aDailyExpenseRecord = new List<string>();
            aDailyExpenseRecord.Add(amount);
            aDailyExpenseRecord.Add(category);
            aDailyExpenseRecord.Add(particuler);
            aWriter.WriteRow(aDailyExpenseRecord);
            MessageBox.Show("Data Save Successfully !!!");
            aFileStream.Close();
        }
        double sum = 0,max=0;
        private void showButton_Click(object sender, EventArgs e)
        {
            sum = 0;

            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> aDailyExpenseRecord = new List<string>();


            while (aReader.ReadRow(aDailyExpenseRecord))
            {
                string expense = aDailyExpenseRecord[0];
                double dailyExpense = Convert.ToDouble(aDailyExpenseRecord[0]);
                sum += dailyExpense;
                if (max < dailyExpense) 
                {
                    max = dailyExpense;
                }
            }
            totalExpenseTextBox.Text = sum.ToString();
            maxExpenseTextBox.Text = max.ToString();
            aFileStream.Close();
        }

        private void showCategorywiseExpenseButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> aDailyExpenseRecord = new List<string>();

            showListBox.Items.Clear();
            while (aReader.ReadRow(aDailyExpenseRecord))
            {
                if(showCategoryComboBox.Text == aDailyExpenseRecord[1])
                {
                    string expense = aDailyExpenseRecord[0];
                    double dailyExpense = Convert.ToDouble(aDailyExpenseRecord[0]);
                    string particuler = aDailyExpenseRecord[2];
                    sum += dailyExpense;
                    showListBox.Items.Add(expense + " " +particuler);
             
                }
               
            }
            showCategorywiseTotalExpenseTextBox.Text = sum.ToString();
            aFileStream.Close();

        }
    }
}

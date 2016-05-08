using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_CoursePrj
{
    public partial class QuationsForm : Form
    {
        Form MainFormSH;
        static int RBCount = 0;

        public QuationsForm(MainForm MainForm)
        {
            InitializeComponent();
            MaximizeBox = false;

            MainFormSH = MainForm;
            MainFormSH.Hide();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            fundTextBox.Enabled = radioButton18.Checked;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {           
            var CC = groupBox7.Controls;
            List<string> CheckedBox = new List<string>();
            foreach (var Control in CC)
            {
                if (Control is CheckBox && (Control as CheckBox).Checked == true)
                {
                    CheckedBox.Add((Control as CheckBox).Text);
                }
            }

            if (CheckedBox.Any() && (fundTextBox.Text != "" || fundTextBox.Enabled == false) && (whatTextBox.Text != "" || whatTextBox.Enabled == false) && (depositTextBox.Text != "" || depositTextBox.Enabled == false))
            {
                string[] what = whatTextBox.Text.Split(' ');
                int fund = 1;
                int deposit = 2;              

                MessageBox.Show("Success!");

                // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Table". При необходимости она может быть перемещена или удалена.
                //this.tableTableAdapter.Fill(this.databaseDataSet.Table);
                //this.Validate();
                //this.tableBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.databaseDataSet);
            }
            else
            {
                MessageBox.Show("Fail!");
            }
            CheckedBox.Clear();
        }

        private void QuationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFormSH.Show();
        }
        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void QuationsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter1.Fill(this.databaseDataSet.Table);

        }

        private void dependencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           depositTextBox.Enabled = dependencyCheckBox.Checked;
        }

        private void signCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = signCheckBox.Checked;
        }

        private void responsabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            whatTextBox.Enabled = responsabilityCheckBox.Checked;
        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

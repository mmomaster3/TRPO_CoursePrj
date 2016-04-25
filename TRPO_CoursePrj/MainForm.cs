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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.KeyPreview = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.F && e.Control && e.Shift)
            {
                panel1.Visible = true;
                e.Handled = true;
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "starlife")
            {
                //new Form2().Show();
                //Hide();
            }
            else
            {
                MessageBox.Show("Пароль введен неверно!", "Ошибка ввода пароля");
            }
        }

        private void buttonEtrQuations_Click(object sender, EventArgs e)
        {
            new QuationsForm(this).ShowDialog();
        }
    }
}

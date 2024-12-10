using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit Edit = new Edit();
            Edit.Show();
            Hide();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Record Record = new Record();
            Record.Show();
            Hide();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            View View = new View();
            View.Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_16ip213DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_16ip213DataSet.Service);
            EditButton.Enabled = false;
            RecordButton.Enabled = false;
            ViewButton.Enabled = false;
        }

        private void kodButton_Click(object sender, EventArgs e)
        {
            if(kodBox.Text == "0000")
            {
                EditButton.Enabled = true;
                RecordButton.Enabled = true;
                ViewButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }
    }
}

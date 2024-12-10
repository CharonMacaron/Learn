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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
            Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_16ip213DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_16ip213DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_16ip213DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.school_16ip213DataSet1.Client);

        }

        int TimeInSeconds(int a, int b)
        {
            return a * 3600 + b * 60;
        }
        (int, int) SecondsToTime(int sec)
        {
            int ch = sec / 3600;
            sec %= 3600;
            int min = sec / 60;
            return (ch, min);
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = Convert.ToInt32(textBox1.Text);
            min = Convert.ToInt32(textBox2.Text);
            sec = TimeInSeconds(ch, min);
            int dur = Convert.ToInt32(textBox3.Text);
            sec += dur;
            (int ch, int min) result = SecondsToTime(sec);
            textBox4.Text = Convert.ToString(result.ch);
            textBox5.Text = Convert.ToString(result.min);
            
        }
    }
}

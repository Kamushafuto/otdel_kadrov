using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otdel
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.otdel_zalupaDataSet.sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.rab_dni". При необходимости она может быть перемещена или удалена.
            this.rab_dniTableAdapter.Fill(this.otdel_zalupaDataSet.rab_dni);
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rab_dniTableAdapter.InsertQuery(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Text, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            rab_dniTableAdapter.Adapter.Update(otdel_zalupaDataSet.rab_dni);
            rab_dniTableAdapter.Fill(otdel_zalupaDataSet.rab_dni);
        }
    }
}

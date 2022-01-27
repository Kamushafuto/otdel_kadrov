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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void sotrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.otdel_zalupaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.dolj". При необходимости она может быть перемещена или удалена.
            this.doljTableAdapter.Fill(this.otdel_zalupaDataSet.dolj);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.otdel_zalupaDataSet.otdel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.otdel_zalupaDataSet.sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.otdel_zalupaDataSet.sotr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sotrTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue));
            sotrTableAdapter.Adapter.Update(otdel_zalupaDataSet.sotr);
            sotrTableAdapter.Fill(otdel_zalupaDataSet.sotr);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotrTableAdapter.FillBy(otdel_zalupaDataSet.sotr,textBox4.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sotrTableAdapter.DeleteQuery(Convert.ToInt32(id_sotrComboBox.SelectedValue));
            sotrTableAdapter.Adapter.Update(otdel_zalupaDataSet.sotr);
            sotrTableAdapter.Fill(otdel_zalupaDataSet.sotr);
        }
    }
}

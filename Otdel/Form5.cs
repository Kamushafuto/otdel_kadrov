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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.rab_dni". При необходимости она может быть перемещена или удалена.
            this.rab_dniTableAdapter.Fill(this.otdel_zalupaDataSet.rab_dni);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.otdel_zalupaDataSet.sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.zarp". При необходимости она может быть перемещена или удалена.
            this.zarpTableAdapter.Fill(this.otdel_zalupaDataSet.zarp);

        }

        private void button1_Click(object sender, EventArgs e)
        { if (textBox1.Text == "")
            {
                MessageBox.Show("Рассчитайте ЗП", "Danger master");
            }
            else
            {
                zarpTableAdapter.InsertQuery(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Text, Convert.ToInt32(textBox1.Text));
                zarpTableAdapter.Adapter.Update(this.otdel_zalupaDataSet.zarp);
                this.zarpTableAdapter.Fill(this.otdel_zalupaDataSet.zarp);
                textBox1.Clear();
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b,c;
            b = Convert.ToInt32( kol_rab_dneyTextBox.Text);
            c = 50 * b;
           
            textBox1.Text = Convert.ToString(c); ;

        }
    }
}

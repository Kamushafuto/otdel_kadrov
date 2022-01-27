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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void otdelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.otdel_zalupaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_zalupaDataSet.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.otdel_zalupaDataSet.otdel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            otdelTableAdapter.InsertQuery(textBox1.Text, Convert.ToInt32(textBox2.Text), maskedTextBox1.Text, textBox4.Text);
            otdelTableAdapter.Adapter.Update(otdel_zalupaDataSet.otdel);
            otdelTableAdapter.Fill(otdel_zalupaDataSet.otdel);
        }

      
    }
}


namespace Otdel
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.otdel_zalupaDataSet = new Otdel.Otdel_zalupaDataSet();
            this.zarpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarpTableAdapter = new Otdel.Otdel_zalupaDataSetTableAdapters.zarpTableAdapter();
            this.tableAdapterManager = new Otdel.Otdel_zalupaDataSetTableAdapters.TableAdapterManager();
            this.zarpDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrTableAdapter = new Otdel.Otdel_zalupaDataSetTableAdapters.sotrTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rab_dniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rab_dniTableAdapter = new Otdel.Otdel_zalupaDataSetTableAdapters.rab_dniTableAdapter();
            this.kol_rab_dneyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_zalupaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rab_dniBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.formLabel);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1117, 25);
            this.panelMenu.TabIndex = 17;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.BackColor = System.Drawing.Color.Transparent;
            this.formLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.formLabel.Location = new System.Drawing.Point(471, 5);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(81, 15);
            this.formLabel.TabIndex = 3;
            this.formLabel.Text = "Отдел кадров";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Otdel.Properties.Resources.cancel;
            this.pictureBox3.Location = new System.Drawing.Point(1089, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // otdel_zalupaDataSet
            // 
            this.otdel_zalupaDataSet.DataSetName = "Otdel_zalupaDataSet";
            this.otdel_zalupaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zarpBindingSource
            // 
            this.zarpBindingSource.DataMember = "zarp";
            this.zarpBindingSource.DataSource = this.otdel_zalupaDataSet;
            // 
            // zarpTableAdapter
            // 
            this.zarpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.doljTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Otdel.Otdel_zalupaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // zarpDataGridView
            // 
            this.zarpDataGridView.AutoGenerateColumns = false;
            this.zarpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zarpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.zarpDataGridView.DataSource = this.zarpBindingSource;
            this.zarpDataGridView.Location = new System.Drawing.Point(12, 36);
            this.zarpDataGridView.Name = "zarpDataGridView";
            this.zarpDataGridView.Size = new System.Drawing.Size(761, 241);
            this.zarpDataGridView.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rab_dniBindingSource;
            this.comboBox1.DisplayMember = "fam";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "id_sotr";
            // 
            // sotrBindingSource
            // 
            this.sotrBindingSource.DataMember = "sotr";
            this.sotrBindingSource.DataSource = this.otdel_zalupaDataSet;
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Добваить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "Расчитать ЗП";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rab_dniBindingSource
            // 
            this.rab_dniBindingSource.DataMember = "rab_dni";
            this.rab_dniBindingSource.DataSource = this.otdel_zalupaDataSet;
            // 
            // rab_dniTableAdapter
            // 
            this.rab_dniTableAdapter.ClearBeforeFill = true;
            // 
            // kol_rab_dneyTextBox
            // 
            this.kol_rab_dneyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rab_dniBindingSource, "kol_rab_dney", true));
            this.kol_rab_dneyTextBox.Location = new System.Drawing.Point(341, 170);
            this.kol_rab_dneyTextBox.Name = "kol_rab_dneyTextBox";
            this.kol_rab_dneyTextBox.Size = new System.Drawing.Size(100, 20);
            this.kol_rab_dneyTextBox.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(800, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 241);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fam";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ima";
            this.dataGridViewTextBoxColumn6.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "otch";
            this.dataGridViewTextBoxColumn7.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mes";
            this.dataGridViewTextBoxColumn3.HeaderText = "Месяц";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "zp";
            this.dataGridViewTextBoxColumn4.HeaderText = "ЗП";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Дата ЗП";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "ЗП";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zarpDataGridView);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.kol_rab_dneyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_zalupaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rab_dniBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Otdel_zalupaDataSet otdel_zalupaDataSet;
        private System.Windows.Forms.BindingSource zarpBindingSource;
        private Otdel_zalupaDataSetTableAdapters.zarpTableAdapter zarpTableAdapter;
        private Otdel_zalupaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView zarpDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private Otdel_zalupaDataSetTableAdapters.sotrTableAdapter sotrTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource rab_dniBindingSource;
        private Otdel_zalupaDataSetTableAdapters.rab_dniTableAdapter rab_dniTableAdapter;
        private System.Windows.Forms.TextBox kol_rab_dneyTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
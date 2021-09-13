using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting.view
{
    public partial class ListTransaction : MetroFramework.Forms.MetroForm
    {
        public ListTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listtransactionTableAdapter.Fill(this.dataSet1.Listtransaction, dateTimePicker1.Value, dateTimePicker2.Value);

            this.dataGridView1.Refresh();
        }

        private void ListTransaction_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

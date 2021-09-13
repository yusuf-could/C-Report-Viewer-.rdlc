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
    public partial class ListOfItem : MetroFramework.Forms.MetroForm
    {
        public ListOfItem()
        {
            InitializeComponent();
        }

        private void ListOfItem_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblpawn_tmTableAdapter.Fill(this.dataSet1.tblpawn_tm, dateTimePicker1.Value, dateTimePicker2.Value);

            this.dataGridView1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

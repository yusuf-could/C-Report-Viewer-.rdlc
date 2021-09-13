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
    public partial class ListStuffOut : MetroFramework.Forms.MetroForm
    {
        public ListStuffOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.stuffOutTableAdapter.Fill(this.dataSet1.StuffOut, dateTimePicker1.Value, dateTimePicker2.Value);

            this.dataGridView1.Refresh();
        }

        private void ListStuffOut_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}

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
    public partial class CustomerList : MetroFramework.Forms.MetroForm
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblcustomer_tm1TableAdapter.Fill(this.dataSet1.tblcustomer_tm1, dateTimePicker1.Value, dateTimePicker2.Value);

            this.dataGridView1.Refresh();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[15].DefaultCellStyle.Format = "dd/MM/yyyy";

            //dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
        }
    }
}

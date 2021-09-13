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
    public partial class ListPayment : MetroFramework.Forms.MetroForm
    {
        public ListPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.paymentReportTableAdapter.Fill(this.dataSet1.PaymentReport, dateTimePicker1.Value, dateTimePicker2.Value);

            this.dataGridView1.Refresh();
        }

        private void ListPayment_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

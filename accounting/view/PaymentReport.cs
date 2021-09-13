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
    public partial class PaymentReport : MetroFramework.Forms.MetroForm
    {
        public PaymentReport()
        {
            InitializeComponent();
        }

        private void PaymentReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.paymentReportTableAdapter.Fill(this.dataSet1.PaymentReport, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}

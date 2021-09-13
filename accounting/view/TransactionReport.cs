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
    public partial class TransactionReport : MetroFramework.Forms.MetroForm
    {
        public TransactionReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.report' table. You can move, or remove it, as needed.
            //this.reportTableAdapter.Fill(this.dataSet1.report);
            // TODO: This line of code loads data into the 'dataSet1.report' table. You can move, or remove it, as needed.
            // this.reportTableAdapter.Fill(this.dataSet1.report);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportTableAdapter.Fill(this.dataSet1.report, dateTimePicker1.Value,dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
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
    }
}

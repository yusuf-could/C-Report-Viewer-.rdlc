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
    public partial class Report_Customer : MetroFramework.Forms.MetroForm
    {
        public Report_Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblcustomer_tm1TableAdapter.Fill(this.dataSet1.tblcustomer_tm1, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }

        private void Report_Customer_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

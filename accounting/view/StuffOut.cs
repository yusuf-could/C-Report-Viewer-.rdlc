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
    public partial class StuffOut : MetroFramework.Forms.MetroForm
    {
        public StuffOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.stuffOutTableAdapter.Fill(this.dataSet1.StuffOut, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}

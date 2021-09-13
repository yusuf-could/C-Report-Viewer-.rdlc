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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void TransactionReport_Click_1(object sender, EventArgs e)
        {
            TransactionReport tct = new TransactionReport();
            tct.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Report_Customer cs = new Report_Customer();
            cs.ShowDialog();
        }

        private void ItemReport_Click(object sender, EventArgs e)
        {
            ReportProduct rpt = new ReportProduct();
            rpt.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ListPayment lpt = new ListPayment();
            lpt.ShowDialog();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList csl = new CustomerList();
            csl.ShowDialog();
        }

        private void TransactionList_Click(object sender, EventArgs e)
        {
            ListTransaction lst = new ListTransaction();
            lst.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //timer1.Start();

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lblclok.Text = DateTime.Now.ToString("T");
            }));
        }

        private void ListItem_Click(object sender, EventArgs e)
        {
            ListOfItem lst = new ListOfItem();
            lst.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblclok.Text = DateTime.Now.ToString("T");
        }

        private void PaymentReport_Click(object sender, EventArgs e)
        {
            PaymentReport pyrt = new PaymentReport();
            pyrt.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolAddUser_Click(object sender, EventArgs e)
        {
            AddUser ad = new AddUser();
            ad.ShowDialog();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            StuffOut st = new StuffOut();
            st.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            ListStuffOut lst = new ListStuffOut();
            lst.ShowDialog();
        }

        private void ReportStuffOut_Click(object sender, EventArgs e)
        {
            StuffOut sf = new StuffOut();
            sf.ShowDialog();
        }

        private void ListStuffOut_Click(object sender, EventArgs e)
        {
            ListStuffOut sfo = new ListStuffOut();
            sfo.ShowDialog();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Example ex = new Example();
            ex.ShowDialog();
        }

        private void dataUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser ad = new AddUser();
            ad.ShowDialog();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList csl = new CustomerList();
            csl.ShowDialog();
        }

        private void paymentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPayment st = new ListPayment();
            st.ShowDialog();
        }

        private void transactionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTransaction tr = new ListTransaction();
            tr.ShowDialog();
        }

        private void listOfItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfItem of = new ListOfItem();
            of.ShowDialog();
        }

        private void stuffOutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStuffOut uf = new ListStuffOut();
            uf.ShowDialog();
        }

        private void itemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProduct pf = new ReportProduct();
            pf.ShowDialog();
        }

        private void paymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentReport prt = new PaymentReport();
            prt.ShowDialog();
        }

        private void reportCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Customer rpc = new Report_Customer();
            rpc.ShowDialog();
        }

        private void transactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionReport tcr = new TransactionReport();
            tcr.ShowDialog();
        }

        private void stuffOutReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuffOut so = new StuffOut();
            so.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using accounting.controller;

namespace accounting.view
{
    public partial class AddUser : MetroFramework.Forms.MetroForm
    {
        User us = new User();
        public AddUser()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbluseradd' table. You can move, or remove it, as needed.
            this.tbluseraddTableAdapter.Fill(this.dataSet1.tbluseradd);
            // TODO: This line of code loads data into the 'dataSet1.tbluseradd' table. You can move, or remove it, as needed.
            //this.tbluseraddTableAdapter.Fill(this.dataSet1.tbluseradd);

            this.dataGridView1.Refresh();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create();
            read();
            ClearData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView sengrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNama.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtAlamat.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtEmail.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtPassword.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Don't click the header");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
            read();
            ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
            read();
            ClearData();
        }

        public void read()
        {
            dataGridView1.DataSource = null;
            us.read_data();
            dataGridView1.DataSource = us.dt;
        }

        public void create()
        {
            us.username = txtNama.Text;
            us.address = txtAlamat.Text;
            us.email = txtEmail.Text;
            us.password = txtPassword.Text;
            us.create_data();
        }

        public void update()
        {
            us.id = ID.Text;
            us.username = txtNama.Text;
            us.address = txtAlamat.Text;
            us.email = txtEmail.Text;
            us.password = txtPassword.Text;
            us.update_data();
        }

        public void delete()
        {
            us.id = ID.Text;
            us.delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView sengrid = (DataGridView)sender;
            try
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNama.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtAlamat.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtEmail.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtPassword.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Don't click the header");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

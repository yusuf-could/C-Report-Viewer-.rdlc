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

namespace accounting.view
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*'; 
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string result = "";
           
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["accounting.Properties.Settings.sgsprodConnectionString"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbluseradd WHERE username=@username AND password=@password", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@username", txtusername.Text.ToString());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.ToString());
                        MySqlDataReader rd = cmd.ExecuteReader();
                            if (rd.Read())
                            {
                                if (rd["password"].ToString().Equals(txtpassword.Text.ToString(), StringComparison.InvariantCulture))
                                {
                                    model.UserInfo.username = rd["username"].ToString();
                                    model.UserInfo.address = rd["address"].ToString();
                                    model.UserInfo.email = rd["email"].ToString();
                                    result = "1";
                                }
                                else
                                    result = "Invalid Credential";
                            }
                            else
                                result = "username & password salah";

                            rd.Close();
                            cmd.Dispose();
                            con.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                result = ex.Message.ToString();
            }

            if (result == "1")
            {
                Program.dasbord = true;
                this.Close();
            }
            else
                MessageBox.Show(result);
        }
    }
}

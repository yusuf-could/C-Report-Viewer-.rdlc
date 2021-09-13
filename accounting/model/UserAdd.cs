using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace accounting.model
{
    class UserAdd
    {
        public int id { get; set; }
        public string username { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public void add(string username, string address, string email, string password)
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["accounting.Properties.Settings.sgsprodConnectionString"].ConnectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tbluseradd (username,address, email, password) VALUES ('"+username+"','"+address+"','"+email+"','"+password+"')" , con))
                    {
                        cmd.ExecuteReader();
                        con.Close();
                    }
                }
            }
            catch(Exception)
            {
    
            }
        }

        public void update(string username, string address, string email, string password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["accounting.Properties.Settings.sgsprodConnectionString"].ConnectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE tbluseradd SET username=username, address=address, email=email, password=password", con))
                    {
                        using(MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            cmd.ExecuteReader();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {
              
            }
        }

        public void delete(string username)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["accounting.Properties.Settings.sgsprodConnectionString"].ConnectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DELETE tbluseradd WHERE username=username", con))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            cmd.ExecuteReader();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

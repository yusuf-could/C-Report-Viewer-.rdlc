using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace accounting.controller
{
    class Db
    {
        public MySqlConnection con;

        public Db()
        {
            string server = "192.168.1.12";
            string port = "3306";
            string user = "root";
            string pass = "@Qwert!123";
            string db = "sgsprod";
            string constring = "datasource = "+server+"; port = "+port+"; username = "+user+"; password = "+pass+"; database = "+db+"; SslMode=None";
            //con = new MySqlConnection(ConfigurationManager.ConnectionStrings["accounting.Properties.Settings.sgsprodConnectionString"].ConnectionString);
            con = new MySqlConnection(constring);
        }
    }

    class User : Db
    {
        public string id { get; set; }
        public string username { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void create_data()
        {
            con.Open();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO tbluseradd (username,address,email,password) VALUES (@username,@address,@email,@password)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;


                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void update_data()
        {
            con.Open();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE tbluseradd SET username=@username, address=@address, email=@email, password=@password WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void delete_data()
        {
            con.Open();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM tbluseradd WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
               
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM tbluseradd";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con);
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}

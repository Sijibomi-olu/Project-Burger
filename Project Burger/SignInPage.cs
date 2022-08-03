using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Burger
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username/Email address"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username/Email address";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siji;";
            string query = "SELECT INTO verification VALUES(' " + username + "', '" + password + "' )";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                commandDatabase.Connection = databaseConnection;
                commandDatabase.CommandText = "select * from verification";
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    if (txtUsername.Text.Equals(reader["username"].ToString()) && txtPassword.Text.Equals(reader["password"].ToString()))
                    {
                        MessageBox.Show("Login Successful", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 w = new Form1();
                        w.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Either your username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siji;";
            string query = "INSERT INTO verification VALUES(' " + username + "', '" + password + "' )";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Burger
{
    public partial class MeatPizzaControl : UserControl
    {
        public MeatPizzaControl()
        {
            InitializeComponent();
        }

        MySqlConnection connectionstring = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=siji");

        private void Thirdcontrol_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Mexican Fiesta
        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Mexican Fiesta";
            int quantity = int.Parse(QtyBox1.Text);
            string query = "insert into cart(name,quantity) values ('" + name + "','" + quantity + "')";
            connectionstring.Open();
            MySqlCommand command = new MySqlCommand(query, connectionstring);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ADDED TO CART");
                }
                else
                {
                    MessageBox.Show("UNABLE TO ADD TO CART");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionstring.Close();
        }

        //Hawaiian
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Hawaiian";
            int quantity = int.Parse(QtyBox2.Text);
            string query = "insert into cart(name,quantity) values ('" + name + "','" + quantity + "')";
            connectionstring.Open();
            MySqlCommand command = new MySqlCommand(query, connectionstring);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ADDED TO CART");
                }
                else
                {
                    MessageBox.Show("UNABLE TO ADD TO CART");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionstring.Close();
        }

        //Triple Decker
        private void button3_Click(object sender, EventArgs e)
        {
            string name = "Triple Decker";
            int quantity = int.Parse(QtyBox3.Text);
            string query = "insert into cart(name,quantity) values ('" + name + "','" + quantity + "')";
            connectionstring.Open();
            MySqlCommand command = new MySqlCommand(query, connectionstring);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ADDED TO CART");
                }
                else
                {
                    MessageBox.Show("UNABLE TO ADD TO CART");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionstring.Close();
        }

        //Sausage
        private void button6_Click(object sender, EventArgs e)
        {
            string name = "Sausage";
            int quantity = int.Parse(QtyBox4.Text);
            string query = "insert into cart(name,quantity) values ('" + name + "','" + quantity + "')";
            connectionstring.Open();
            MySqlCommand command = new MySqlCommand(query, connectionstring);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ADDED TO CART");
                }
                else
                {
                    MessageBox.Show("UNABLE TO ADD TO CART");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionstring.Close();
        }

        //Four Seasons
        private void button5_Click(object sender, EventArgs e)
        {
            string name = "Four Seasons";
            int quantity = int.Parse(QtyBox5.Text);
            string query = "insert into cart(name,quantity) values ('" + name + "','" + quantity + "')";
            connectionstring.Open();
            MySqlCommand command = new MySqlCommand(query, connectionstring);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ADDED TO CART");
                }
                else
                {
                    MessageBox.Show("UNABLE TO ADD TO CART");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionstring.Close();
        }
         //Meaty club
        private void button4_Click(object sender, EventArgs e)
        {
            string name = "Meaty Club";
            int quantity = int.Parse(QtyBox6.Text);
            string query = "insert into cart(name,quantity) values ('" + name + "','" + quantity + "')";
            connectionstring.Open();
            MySqlCommand command = new MySqlCommand(query, connectionstring);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ADDED TO CART");
                }
                else
                {
                    MessageBox.Show("UNABLE TO ADD TO CART");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionstring.Close();
        }
    }
}

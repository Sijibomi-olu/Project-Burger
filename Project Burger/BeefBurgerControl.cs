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
    public partial class BeefBurgerControl : UserControl
    {
        public BeefBurgerControl()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        MySqlConnection connectionstring = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=siji");
        
        // Single Decker Burger
        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Single Decker Burger";
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

        //Double Decker Burger
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Double Decker Burger";
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

        //Triple Decker Burger
        private void button3_Click(object sender, EventArgs e)
        {
            string name = "Triple Decker Burger";
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

        //King Burger
        private void button6_Click(object sender, EventArgs e)
        {
            string name = "King Burger";
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

        //Feasty Beef
        private void button4_Click(object sender, EventArgs e)
        {
            string name = "Feasty Beef Burger";
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

        // BBQ Bacon Burger
        private void button5_Click(object sender, EventArgs e)
        {
            string name = "BBQ Bacon Burger";
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

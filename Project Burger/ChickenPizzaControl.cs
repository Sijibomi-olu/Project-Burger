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
    public partial class ChickenPizzaControl : UserControl
    {
        public ChickenPizzaControl()
        {
            InitializeComponent();
        }

        MySqlConnection connectionstring = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=siji");

        //Tikka Chicken
        private void button6_Click(object sender, EventArgs e)
        {
            string name = "Tikka Chicken";
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

        //Chicken and Mushroom
        private void button5_Click(object sender, EventArgs e)
        {
            string name = "Chicken and Mushroom";
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

        //BBQ Chicken
        private void button4_Click(object sender, EventArgs e)
        {
            string name = "BBQ Chicken";
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

        //Chicken Feta
        private void button3_Click(object sender, EventArgs e)
        {
            string name = "Chicken, Feta and Avo";
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

        //Sweet and Sour Chicken
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Sweet and Sour Chicken";
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
    }
}

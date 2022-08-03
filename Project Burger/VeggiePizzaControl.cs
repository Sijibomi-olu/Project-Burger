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
    public partial class VeggiePizzaControl : UserControl
    {
        public VeggiePizzaControl()
        {
            InitializeComponent();
        }

        MySqlConnection connectionstring = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=siji");

        //Cheese
        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Cheese";
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

        //Margherita
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Margherita";
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

        //Original Veggie
        private void button3_Click(object sender, EventArgs e)
        {
            string name = "Original Veggie";
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
    }
}

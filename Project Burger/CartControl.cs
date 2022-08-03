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
    public partial class CartControl : UserControl
    {
        public CartControl()
        {
            InitializeComponent();
        }

        private void CartControl_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectionstring = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database = siji");
                MySqlDataAdapter adap = new MySqlDataAdapter("select * from cart", connectionstring);
                DataSet ds;
                connectionstring.Open();
                ds = new System.Data.DataSet();
                adap.Fill(ds, "person details");
                dataGridView1.DataSource = ds.Tables[0];
                connectionstring.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

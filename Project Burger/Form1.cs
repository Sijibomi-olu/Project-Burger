using Project_Burger.Properties;
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
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panel4; }
            set { panel4 = value; }
        }

        public Button BackButton
        {
            get { return backbutton; }
            set { backbutton = value; }
        }

        public bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;
            firstControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;
            firstControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button5.Height;
            Sidepanel.Top = button5.Top;
            burgerControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            pizza_Control1.BringToFront(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;          
            CartForm lg = new CartForm();
            lg.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button11.Image = Resources.up_arrow1;
                paneldropdown.Height += 10;
                if (paneldropdown.Size == paneldropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button11.Image = Resources.down_arrow1;
                paneldropdown.Height -= 10;
                if (paneldropdown.Size == paneldropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            SignInPage lg = new SignInPage();
            lg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backbutton.Visible = false;
            _obj = this;

            BurgerControl uc = new BurgerControl();
         
            uc.Dock = DockStyle.Fill;
            panel4.Controls.Add(uc);
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            panel4.Controls["BurgerControl"].BringToFront();         
            backbutton.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button7.Height;
            Sidepanel.Top = button7.Top;
            contactControl1.BringToFront();
        }

        MySqlConnection connectionstring = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=siji");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            connectionstring.Open();
            string query = "DELETE FROM cart ";
            MySqlCommand command = new MySqlCommand(query, connectionstring);
            try
            {
                if(command.ExecuteNonQuery() == 1)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connectionstring.Close();
            Application.Exit();
        }
    }
}

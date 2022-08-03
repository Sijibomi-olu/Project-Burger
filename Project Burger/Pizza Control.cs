using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Burger
{
    public partial class Pizza_Control : UserControl
    {
        public Pizza_Control()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.panel4.Controls.ContainsKey("BeefBurgerControl"))
            {
                MeatPizzaControl un = new MeatPizzaControl();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panel4.Controls.Add(un);
            }
            Form1.Instance.panel4.Controls["MeatPizzaControl"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.panel4.Controls.ContainsKey("BeefBurgerControl"))
            {
                ChickenPizzaControl un = new ChickenPizzaControl();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panel4.Controls.Add(un);
            }
            Form1.Instance.panel4.Controls["ChickenPizzaControl"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.panel4.Controls.ContainsKey("BeefBurgerControl"))
            {
                VeggiePizzaControl un = new VeggiePizzaControl();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panel4.Controls.Add(un);
            }
            Form1.Instance.panel4.Controls["VeggiePizzaControl"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }
    }
}

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
    public partial class BurgerControl : UserControl
    {
        public BurgerControl()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if(!Form1.Instance.panel4.Controls.ContainsKey("BeefBurgerControl"))
            {
                BeefBurgerControl un = new BeefBurgerControl();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panel4.Controls.Add(un);
            }
            Form1.Instance.panel4.Controls["BeefBurgerControl"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.panel4.Controls.ContainsKey("ChickenBurgerControl"))
            {
                ChickenBurgerControl un = new ChickenBurgerControl();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panel4.Controls.Add(un);
            }
            Form1.Instance.panel4.Controls["ChickenBurgerControl"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }
    }
}

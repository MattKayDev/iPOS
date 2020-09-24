using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class frmPizzaSize : Form
    {

        public frmPizzas frmPizzas { get; set; }
       
        public frmPizzaSize()
        {
            InitializeComponent();
        }

        private void frmPizzaSize_Load(object sender, EventArgs e)
        {
            frmPizzas.frmPS = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frmPizzas selectedPizza = new frmPizzas();
            //selectedPizza.Show();
            frmPizzas.pizzaSize = 10;
            frmPizzas.showPizza();
            this.Hide();
            //selectedPizza.pizzaSize = 10;
            //selectedPizza.showPizza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmPizzas selectedPizza = new frmPizzas();
            //selectedPizza.Show();
            frmPizzas.pizzaSize = 12;
            frmPizzas.showPizza();
            //selectedPizza.pizzaSize = 10;
            //selectedPizza.showPizza();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmPizzas selectedPizza = new frmPizzas();
            //selectedPizza.Show();
            frmPizzas.pizzaSize = 14;
            frmPizzas.showPizza();
            //selectedPizza.pizzaSize = 10;
            //selectedPizza.showPizza();
            this.Hide();
        }
    }
}

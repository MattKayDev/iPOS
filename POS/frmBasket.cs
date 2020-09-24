using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class frmBasket : Form
    {
        public frmBasket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPizzas selectPizza = new frmPizzas();
            selectPizza.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class frmPizzas : Form
    {

        public int pizzaSize;

        public bool Margherita;
        public bool hawaiian;
        public bool tuscany;
        public bool napoli;
        public bool southern;
        public bool spicyChicken;
        public bool spicyBeef;
        public bool donner;
        public bool donnerHot;
        public bool meatFeast;
        public bool veg;
        public bool seafood;
        public bool italianHot;
        public bool ilPadrino;

        string selectedPizzaWithSize;
        string selectedPizza;

        const string quote = "\"";

        public frmPizzaSize frmPS = new frmPizzaSize();

        public frmPizzas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmPizzaSize selectSize = new frmPizzaSize();
          
            Margherita = true;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        public void showPizza()
        {

            if (Margherita)
            {
                selectedPizza = "MARGHERITA";
            }
            else if (hawaiian)
            {
                selectedPizza = "HAWAIIAN";
            }
            else if (napoli)
            {
                selectedPizza = "NAPOLI";
            }
            else if (tuscany)
            {
                selectedPizza = "TUSCANY";
            }
            else if (southern)
            {
                selectedPizza = "SOUTHERN";
            }
            else if (spicyChicken)
            {
                selectedPizza = "SPICY CHICKEN";
            }
            else if (donner)
            {
                selectedPizza = "DONNER";
            }
            else if (donnerHot)
            {
                selectedPizza = "DONNER HOT";
            }
            else if (meatFeast)
            {
                selectedPizza = "MEAT FEAST";
            }
            else if (veg)
            {
                selectedPizza = "VEG";
            }
            else if (seafood)
            {
                selectedPizza = "SEA FOOD";
            }
            else if (italianHot)
            {
                selectedPizza = "ITALIAN FOOD";
            }
            else if (seafood)
            {
                selectedPizza = "SEA FOOD";
            }
            else if (ilPadrino)
            {
                selectedPizza = "IL PADRINO";
            }

            selectedPizzaWithSize = selectedPizza + pizzaSize.ToString() + quote;
            MessageBox.Show(selectedPizzaWithSize);
        }

        private void frmPizzas_Load(object sender, EventArgs e)
        {
            frmPS.frmPizzas = this;
            pizzaSize = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = true;
            tuscany = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;
            napoli = false;

            frmPS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = true;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;
            napoli = false;

            frmPS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = true;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = true;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = true;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = true;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = true;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = true;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = true;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = true;
            ilPadrino = false;

            frmPS.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = false;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = true;

            frmPS.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Margherita = false;
            hawaiian = false;
            tuscany = false;
            napoli = false;
            southern = false;
            spicyChicken = false;
            spicyBeef = false;
            donner = false;
            donnerHot = false;
            meatFeast = true;
            veg = false;
            seafood = false;
            italianHot = false;
            ilPadrino = false;

            frmPS.Show();
        }
    }
}

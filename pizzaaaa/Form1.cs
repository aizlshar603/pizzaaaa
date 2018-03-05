using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaaaa
{
    public partial class Form1 : Form
    {
        int toppings;
        double basePrice, toppingPrice, totalPrice;

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            toppings = Convert.ToInt16(inputLabel.Text);
            basePrice = 7.00;
            toppingPrice = 1.25;
            totalPrice = basePrice + toppingPrice * toppings;
            outPut.Text = "The total of a pizza with "+ toppings + " toppings is " + totalPrice.ToString("C");
       
        }
    }
}

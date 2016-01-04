using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4Pizza
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please enter a name");
            }
            else
            {
                double totalCost = calculateBasePrice() + calculateToppings() + calculateSticks();
                MessageBox.Show("Pizza ordered\n" +
                    "Name: " + textBoxName.Text + "\n" +
                    "Base price: $" + calculateBasePrice() + "\n" +
                    "Price of toppings: $" + calculateToppings() + "\n" +
                    "Price of sticks: $" + calculateSticks() + "\n" +
                    "Total cost: $" + totalCost);
            }
  
        }

        /// <summary>
        /// Returns the base price for each pizza, which is $5 for small, $6 for medium, $7 for large
        /// </summary>
        /// <returns> base price for each size</returns>
        private double calculateBasePrice()
        {
            if(radioSmall.Checked) return 5;
            else if(radioMedium.Checked) return 6;
            else if (radioLarge.Checked) return 7;
            else {
                MessageBox.Show("Size not selected");
            return 0;
            }
        }

        private double calculateToppings()
        {
            double toppingCost = 0;
            var checkBoxes = GroupBoxToppings.Controls.OfType<CheckBox>();
            foreach (CheckBox c in checkBoxes)
            {
             if(c.Checked) toppingCost += 0.5;
            }
            return toppingCost;
        }

        private double calculateSticks()
        {
            return ((double) numericUpDownBreadsticks.Value * 0.5 ) + (double) numericUpDownCheesesticks.Value;
        }



    }
}

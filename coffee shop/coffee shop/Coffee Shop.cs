using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class coffeeShopForm : Form
    {
        const int size = 2, index = 0;

        string[] customerName = new string[size];
        int[] Contact = new int[size];
        string[] Address = new string[size];
        string[] Order = new string[size];
        int[] Quantity = new int[size];
        int Price = 0;
        public coffeeShopForm()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < size)
            {



                customerName[index] = customerNameTextBox.Text;
                Contact[index] = Convert.ToInt32(contactNoTextBox.Text);
                Address[index] = addressTextBox.Text;
                Order[index] = orderComboBox.Text;
                Quantity[index] = Convert.ToInt32(quantityTextBox.Text);

                if (orderComboBox.Text == "Black")
                {
                    Price = 120;
                }
                else if (orderComboBox.Text == "Cold")
                {
                    Price = 100;
                }
                else if (orderComboBox.Text == "Hot")
                {
                    Price = 90;

                }
                else if (orderComboBox.Text == "Regular")
                {
                    Price = 80;

                }



                informationRichTextBox.AppendText("\n\nCustomer Name=" + customerName[index] + "\n\nContact No=" + Contact[index] +
                    "\n\nAddress=" + Address[index] + "\n\nOrder=" + Order[index] + "\n\nQuantity=" + Quantity[index]);









            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hockey_Click(object sender, EventArgs e)
        {
            string playerName = $"Wayne Gretzky";
            int playerNumber = 99;
            textBox.Text = $"{playerName} is number {playerNumber}";
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = (radius * radius) * pi;
            textBox.Text = $"The area of the circle is {area}m^2";
        }

        private void Carpet_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;
            textBox.Text = $"The area of the room is {area}m^2 and the cost is ${totalCost}";
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            double tax = 0.13;
            double shirtPrice = 12.49;
            double shirtTax = shirtPrice * tax;
            double shirtPlusTax = shirtPrice + shirtTax;
            double tendered = 20.00;
            double change = tendered - shirtPlusTax;
            textBox.Text = $"Bill of Sale \n\n Shirt:            ${shirtPrice}\n\n Tax:             ${shirtTax}\n Total:           ${shirtPlusTax}\n\n Tendered:    ${tendered}\n Change:       ${change}";
                

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
			charReplacer o = new charReplacer();
            TextBox2.Text = o.ReplaceCharachtersToSpace(TextBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bus myBus = new Bus();
            myBus.Color = Color.Red;
            myBus.NrOfPassengers = 12;
            Truck myTruck = new Truck();
            myTruck.Color = Color.Black;
            myTruck.LoadCapacity = 14000;
            ListBox1.Items.Add(myBus);
            ListBox1.Items.Add(myTruck);
        }
    }
}
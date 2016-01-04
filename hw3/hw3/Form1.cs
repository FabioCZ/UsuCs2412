using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFerrari_Click(object sender, EventArgs e)
        {
            populateaValues(new SuperCar("Ferrari F40", "2.9l V8",
                471, 3.8, 324, "1987-1992", "http://srv2.betterparts.org/images/ferrari-f40-04.jpg"));
        }

        private void buttonPorsche_Click(object sender, EventArgs e)
        {
            populateaValues(new SuperCar("Porsche 959", "2.9l Flat6",
                444, 3.7, 336, "1986-1989", "http://www.carsfotodb.com/uploads/porsche/porsche-959/porsche-959-06.jpg"));
        }

        private void buttonLamborghini_Click(object sender, EventArgs e)
        {
            populateaValues(new SuperCar("Lamborghini Countach", "3.9l V12",
                370, 5.4, 309, "1974-1990", "http://upload.wikimedia.org/wikipedia/commons/5/50/Lamborghini_Countach_LP500S.jpg"));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //images might take a sec to load because internet
        private void populateaValues(SuperCar superCar)
        {
            labelModel.Text = superCar.model;
            labelEngine.Text = superCar.engine;
            labelHp.Text = superCar.hp.ToString();
            labelAcceleration.Text = superCar.acceleration.ToString();
            labelTopSpeed.Text = superCar.topSpeed.ToString();
            labelProduction.Text = superCar.production;
            pictureBox1.ImageLocation = superCar.imageUrl;
        }


    }
}

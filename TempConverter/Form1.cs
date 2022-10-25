using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double ConvertCtoF(double c)
        {
            return (c * 9 / 5) + 32;
        }
        public double ConvertFtoC(double f)
        {
            return (f - 32) * 5 / 9;
        }

        public double ConvertCtoK(double c)
        {
            return c + 273.15;
        }

        public double
            ConvertKtoC(double k)
        {
            return k - 273.15;
        }

        private void C_to_F_Click(object sender, EventArgs e)
        {
            Temperature_2.Text = ConvertCtoF(Convert.ToDouble(Temperature_1.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temperature_1.Text = ConvertFtoC(Convert.ToDouble(Temperature_2.Text)).ToString();
        }

        private void C_to_K_Click(object sender, EventArgs e)
        {
            Temperature_2.Text = ConvertCtoK(Convert.ToDouble(Temperature_1.Text)).ToString();
        }

        private void K_to_C_Click(object sender, EventArgs e)
        {
            Temperature_1.Text = ConvertKtoC(Convert.ToDouble(Temperature_2.Text)).ToString();
        }
    }
}

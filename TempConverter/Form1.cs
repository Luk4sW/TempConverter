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

        private void C_to_F_Click(object sender, EventArgs e)
        {
            int celsius = Convert.ToInt32(Temperature_1.Text);
            int fahrenheit = (celsius * 9 / 5) + 32;
            Temperature_2.Text = fahrenheit.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fahrenheit = Convert.ToInt32(Temperature_2.Text);
            int celsius = (fahrenheit - 32) * 5 / 9;
            Temperature_1.Text = celsius.ToString();
        }
    }
}

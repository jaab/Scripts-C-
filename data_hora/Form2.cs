using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_hora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private double Maior3(double um, double dois, double tres)
        {
            return Math.Max(Math.Max(um, dois), tres);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Double um = Convert.ToDouble(textBox1.Text);
            Double dois = Convert.ToDouble(textBox2.Text);
            Double tres = Convert.ToDouble(textBox3.Text);

            MessageBox.Show("O maior é: " + Maior3(um,dois,tres).ToString());

        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String nome1 = Convert.ToString(nome.Text);
            double salario1 = Convert.ToDouble(salario.Text);
            double desconto1 = Convert.ToDouble(desconto.Text);
            double bonificacao1 = Convert.ToDouble(bonificacao.Text);
            double liquido1 = 0;

            if (sdesconto.Checked == true)
            {
                liquido1 = salario1 + bonificacao1;

             

            }
            else
            {
                liquido1 = salario1 + bonificacao1 - desconto1;
            }
            liquido.Text=  Convert.ToString(nome1+':'+liquido1);
            MessageBox.Show(liquido.Text);
        }
    }
}

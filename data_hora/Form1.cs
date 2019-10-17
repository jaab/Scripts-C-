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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MostraDiaHora();
        }

        private void MostraDiaHora()
        {
            String[] diadasema = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            String hoje = diadasema[(int)DateTime.Now.DayOfWeek];
            String horalocal = DateTime.Now.ToLongTimeString();
            MessageBox.Show("Dia da semana: "+hoje+"\nHora: "+ horalocal);

           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 novaform = new Form2();
            novaform.Show();
        }
    }
}

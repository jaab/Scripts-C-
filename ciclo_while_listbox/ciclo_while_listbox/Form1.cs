using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclo_while_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /* int  cont = 0, neg = 0;

               do
               {
                   cont++;
                   listBox1.Items.Add(cont);

                   if(cont==10)
                   {
                    break;
                   }
               } while (cont < 20);*/

            //meses do ano
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mes = Convert.ToString(listBox1.SelectedItem);

         /*   if(mes=="Fevereiro")
            {

            }else if (mes == "Fevereiro" || mes=)
            {

            }
            else
            {

            }*/

            /*switch(Convert.ToString(listBox1.SelectedItem))
            {
          
                case "Fevereiro":
                MessageBox.Show("este mês tem 28 a 29 dias");
                break;
                case "Abril":
                case "Junho":
                case "Setembro":
                case "Novembro":
                    MessageBox.Show("este mês tem 30 dias");
                break;
                default:
                 MessageBox.Show("este mês tem 31 dias");
                break;
            }*/

        }
    }
}

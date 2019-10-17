using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clinica
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string valoruser = user.Text;
            string valorpass = pass.Text;
            /*Ligação à base dados e verifica se o user a password estão correctos*/
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='c_clinica';username=root;password=");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter("SELECT `username`, `password` FROM `login` WHERE `username` = '" + valoruser + "' AND `password` = '" + valorpass + "'", connection);
            adapter.Fill(table);

                if (table.Rows.Count <= 0)
                {
                 MessageBox.Show("username ou password incorrecta");
                }
                else
                {

                this.Hide();
                /*vai buscar o acesso à base dados*/
                string acesso;
                string sql = "SELECT `acesso` FROM `login` WHERE `username` = '" + valoruser + "' AND `password` = '" + valorpass + "'";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    acesso = reader.GetString(0);
                    /*Conforme o acesso vai abrir o form correspondente*/
                    switch (acesso)
                    {
                        case "0":
                            var pacientes1 = new pacientes(valoruser) ;
                            pacientes1.Show();
                        break;
                        case "1":
                           
                            var menu1 = new menu(valoruser);
                            menu1.Show();
                        break;
                        case "3":
                            var medicos1 = new medicos(valoruser);
                            medicos1.Show();
                       break;
                    }
 
                }
                connection.Close();

            }
            

            table.Clear();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            /*abre o form inserir novo utilizador*/
            var inserir = new Form3();
            inserir.Show();
        }
    }
}

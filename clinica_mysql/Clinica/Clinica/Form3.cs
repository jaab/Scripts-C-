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
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

    }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string valoruser = user.Text;
            string valorpass = pass.Text;
            string valortipo = comboBox1.Text;

            try
            {
               
                string MyConnection2 = "datasource=localhost;port=3306;Initial Catalog='c_clinica';username=root;password=";
                string Query = "insert into login(username,password,acesso) values('" + valoruser + "','" + valorpass + "','" + valortipo + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();       
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            var formlogin1 = new formlogin();
            formlogin1.Show();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
            var formlogin1 = new formlogin();
            formlogin1.Show();
        }
    }
    }


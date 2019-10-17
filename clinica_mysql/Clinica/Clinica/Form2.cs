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
    public partial class menu : Form
    {
        public menu(string valoruser)
        {
            InitializeComponent();
            label1.Text ="Olá "+valoruser+ " !";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            var formlogin1 = new formlogin();
            formlogin1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='c_clinica';username=root;password=");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter("SELECT * FROM `medicos` order by nome_medico asc", connection);
            adapter.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dataGridView1.DataSource = bsource;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='c_clinica';username=root;password=");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter("SELECT * FROM `pacientes` order by nome_paciente asc", connection);
            adapter.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dataGridView1.DataSource = bsource;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='c_clinica';username=root;password=");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter("SELECT * FROM `consultas` order by id_consulta desc", connection);
            adapter.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dataGridView1.DataSource = bsource;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button3.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='c_clinica';username=root;password=");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter("SELECT * FROM `especialidades` order by id_esp desc", connection);
            adapter.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dataGridView1.DataSource = bsource;

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button4.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='c_clinica';username=root;password=");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter("SELECT * FROM `login` order by id DESC", connection);
            adapter.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dataGridView1.DataSource = bsource;
        }
    }
}

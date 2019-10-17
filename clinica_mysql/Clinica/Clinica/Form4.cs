using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class pacientes : Form
    {
        public pacientes(string valoruser)
        {
            InitializeComponent();
            label1.Text = "Olá " + valoruser + " !";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            var formlogin1 = new formlogin();
            formlogin1.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Fabián Escobar") && txtPassword.Text.Equals("39210915"))
            {
                MessageBox.Show("El administrador ha iniciado sesión");
                this.Hide();

                Escritorio Simulacion = new Escritorio();
                Simulacion.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Las credenciales ingresadas no corresponden al usuario administrador");
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}

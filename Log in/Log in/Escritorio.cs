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
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();
        }

        private void Escritorio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ésta fue una simulación del inicio de sesión en Windows 10");
        }
    }
}

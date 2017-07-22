using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_List_Picture
{
    public partial class Lenguajes : Form
    {
        public Lenguajes()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation= @"I:\UNLaM\DESARROLLO WEB - POLO TECNOLÓGICO\C# - ASP.NET - Windows Forms\Windows Forms - Aplicaciones de escritorio\Combo List Picture\Combo List Picture\images\" + listBoxLenguajes.Text + ".jpg";
            pictureBox2.ImageLocation = @"I:\UNLaM\DESARROLLO WEB - POLO TECNOLÓGICO\C# - ASP.NET - Windows Forms\Windows Forms - Aplicaciones de escritorio\Combo List Picture\Combo List Picture\images\" + comboBoxLenguajes.Text + ".jpg";
        }

    }
}

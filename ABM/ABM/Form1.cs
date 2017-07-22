using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM
{
    public partial class ABMAlumnos : Form
    {
        Conexion alumno = new Conexion();

        string Codigo;

        bool ModificarPresionado;

        public ABMAlumnos()
        {
            InitializeComponent();
        }

        private void ABMAlumnos_Load(object sender, EventArgs e)
        {
            Conexion alumno = new Conexion();

            alumno.ActualizarDataGridView(dgvAlumnos, "select * from alumnos_Tabla;");

            ModificarPresionado = false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (NotEmptyTextBoxes())
            {
                if (ModificarPresionado)
                {
                    alumno.Conectar();

                    string Query = "update alumnos_Tabla set Nombre_Alumno='" + txtNombre.Text + "', Apellido_Alumno='" + txtApellido.Text + "', Edad_Alumno=" + txtEdad.Text + ", Codigo_Alumno=" + Codigo + " where Codigo_Alumno=" + Codigo + ";";

                    alumno.EjecutarSqlQuery(Query);

                    alumno.ActualizarDataGridView(dgvAlumnos, "select * from alumnos_Tabla;");

                    alumno.Desconectar();

                    lblCodigo.Visible = true;
                    txtCodigo.Visible = true;

                    ClearDataTextBoxes();

                    ModificarPresionado = false;  
                }
                else
                {
                    alumno.Conectar();

                    string Query = "insert into alumnos_Tabla(Codigo_Alumno,Nombre_Alumno,Apellido_Alumno,Edad_Alumno) values(" + txtCodigo.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtEdad.Text + ");";

                    alumno.EjecutarSqlQuery(Query);

                    alumno.ActualizarDataGridView(dgvAlumnos, "select * from alumnos_Tabla;");

                    alumno.Desconectar();

                    ClearDataTextBoxes();
                }
            }
            else
                MessageBox.Show("Asegúrese que ningún campo esté vacío y luego vuelva a presionar el botón","Algún campo se encuentra vacío", MessageBoxButtons.OK);
            
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Codigo = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();

            var confirmacion = MessageBox.Show("¿Realmente desea eliminar este registro de la base de datos?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion.Equals(DialogResult.Yes))
            {
                alumno.Conectar();

                string Query = "delete from alumnos_Tabla where Codigo_Alumno=" + Codigo + ";";

                alumno.EjecutarSqlQuery(Query);

                alumno.ActualizarDataGridView(dgvAlumnos, "select * from alumnos_Tabla;");

                alumno.Desconectar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            Codigo = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();

            ModificarPresionado = true;
            lblCodigo.Visible = false;
            txtCodigo.Text = "Modificando";
            txtCodigo.Visible = false;
        }

        public void ClearDataTextBoxes()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtCodigo.Text = string.Empty;
        }

        private void txtBuscarAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            alumno.ActualizarDataGridView(dgvAlumnos, "select * from alumnos_Tabla where Nombre_Alumno like '" + txtBuscarAlumno.Text + "%';");
        }

        private bool NotEmptyTextBoxes()
        {
            if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtEdad.Text == string.Empty || txtCodigo.Text == string.Empty)
                return false;
            return true;
        }
    }
}

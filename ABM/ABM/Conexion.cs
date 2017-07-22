using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABM
{
    public class Conexion
    {
        SqlConnection MiConexion;

        public void Conectar()
        {
            MiConexion = new SqlConnection("Data Source=(local);Initial Catalog=Alumnos;Integrated Security=True"); // pasar como argumento la cadena de conexion, para eso tengo que poder crear un nuevo origen de datos

            MiConexion.Open();
        }

        public void Desconectar()
        {
            MiConexion.Close();
        }

        public void EjecutarSqlQuery(string Query)
        {
            SqlCommand comando = new SqlCommand(Query,MiConexion);

            int FilasAfectadas = comando.ExecuteNonQuery();

            if (FilasAfectadas > 0)
                MessageBox.Show("La operación se ha realizado exitosamente", "La base de datos ha sido actualizada", MessageBoxButtons.OK);
            else
                MessageBox.Show("La operación no ha sido realizado", "La base de datos no ha sido actualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ActualizarDataGridView(DataGridView dgv, string Query)
        {            
            this.Conectar();

            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query,MiConexion);

            MiDataAdapter.Fill(MiDataSet, "alumnos_Tabla");

            dgv.DataSource = MiDataSet;
            dgv.DataMember = "alumnos_Tabla";

            this.Desconectar();
        }
    }
}

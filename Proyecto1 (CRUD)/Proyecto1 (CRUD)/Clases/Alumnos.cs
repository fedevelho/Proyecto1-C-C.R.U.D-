using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1__CRUD_.Clases
{
    internal class Alumnos
    {
        //mostrar alumno
        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {
			try
			{
				Conexion objetoconexion = new Conexion();

				String query = "select * from alumnos";
				tablaAlumnos.DataSource = null;
				MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoconexion.establecerConexcion());
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				tablaAlumnos.DataSource = dt;
				//cerrar conexion
				objetoconexion.cerrarConexion();
			}
			catch (Exception ex)
			{

				MessageBox.Show($"No se mostraron los datos de la base de datos, Error: {ex.Message}");
			}
        }

        //guardar nuevo alumno
        public void guardarAlumnos(TextBox nombres, TextBox apellidos)
        {
            try
            {
                Conexion objetoconexion = new Conexion();

                String query = "insert into alumnos (nombres, apellidos)"+
                    "value ('"+nombres.Text+"','"+apellidos.Text+"')";
                
                MySqlCommand myCommand = new MySqlCommand(query, objetoconexion.establecerConexcion());
                MySqlDataReader reader = myCommand.ExecuteReader(); //ejecutar el comando ingresado
                MessageBox.Show("se guardo los registros");
                while (reader.Read())
                {

                }
                //cerrar conexion
                objetoconexion.cerrarConexion();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"No se mostraron los datos de la base de datos, Error: {ex.Message}");
            }
        }
        //seleccionar la lista
        public void seleccionarAlumnos(DataGridView tablaAlumnos, TextBox id, TextBox nombres, TextBox apellidos)
        {
            try
            {
                id.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                nombres.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                apellidos.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"No se logro seleccionar datos de la base, Error: {ex.Message}");
            }


        }
        //modificar alumno
        public void modificarAlumnos(TextBox id, TextBox nombres, TextBox apellidos)
        {
            try
            {
                Conexion objetoconexion = new Conexion();

                String query = "update alumnos set nombres='" +nombres.Text + "', apellidos='" + apellidos.Text + "' where id='"+id.Text+"';";

                MySqlCommand myCommand = new MySqlCommand(query, objetoconexion.establecerConexcion());
                MySqlDataReader reader = myCommand.ExecuteReader(); //ejecutar el comando ingresado
                MessageBox.Show("se modifico correctamente");
                while (reader.Read())
                {

                }
                //cerrar conexion
                objetoconexion.cerrarConexion();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"No se modificaron los datos de la base de datos, Error: {ex.Message}");
            }
        }
        //eliminar alumnos
        public void EliminarAlumnos(TextBox id)
        {
            try
            {
                Conexion objetoconexion = new Conexion();

                String query = "delete from alumnos where id='" + id.Text +"';";

                MySqlCommand myCommand = new MySqlCommand(query, objetoconexion.establecerConexcion());
                MySqlDataReader reader = myCommand.ExecuteReader(); //ejecutar el comando ingresado
                MessageBox.Show("se elimino correctamente");
                while (reader.Read())
                {

                }
                //cerrar conexion
                objetoconexion.cerrarConexion();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"No se modificaron los datos de la base de datos, Error: {ex.Message}");
            }
        }
    }
}

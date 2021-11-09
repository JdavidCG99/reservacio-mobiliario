using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Reservaciones
{
	class AutoCompleClass
	{
		public static DataTable Datos()
		{
			DataTable dt = new DataTable();

			SqlConnection conexion = new SqlConnection("Server=DESKTOP-K6GJS3D;Database=Sistema_Renta_Mobiliario;integrated security=true");

			string consulta = "select CONCAT(idCliente,' ',nombre,' ',apellidoP,' ',apellidoM) as clientes from Cliente where estatus=1"; //consulta a la tabla paises
			SqlCommand comando = new SqlCommand(consulta, conexion);

			SqlDataAdapter adap = new SqlDataAdapter(comando);

			adap.Fill(dt);
			return dt;
		}

		//metodo para cargar la coleccion de datos para el autocomplete
		public static AutoCompleteStringCollection Autocomplete()
		{
			DataTable dt = Datos();

			AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
			//recorrer y cargar los items para el autocompletado
			foreach (DataRow row in dt.Rows)
			{
				coleccion.Add(Convert.ToString(row["clientes"]));
			}

			return coleccion;
		}
	}
}

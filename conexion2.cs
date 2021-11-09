using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
namespace Sistema_Reservaciones
{

    class Conexion2
    {

        SqlConnection con;
        SqlCommand comando;
        SqlDataReader reader;
        public Conexion2()
        {
            //cadena conexion
            //necesaria para conectar a una bdd en otra compu
            //con = new SqlConnection("Server=DESKTOP-09LLDOK\\LOLIS;Database=Sistema_Renta_Mobiliario;integrated security=true");
            con = new SqlConnection("Server=DESKTOP-K6GJS3D;Database=Sistema_Renta_Mobiliario;integrated security=true");
        }
        private SqlConnection conectar()
        {
            try
            {
                con.Open();
                //MessageBox.Show("Conexion exitosa");
                return con;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error al conectar con la bdd");
                return null;

            }
        }
        private bool cerrar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }
        //sirve para ejecutar insert, update's y delete
        public bool ejecutar(string query)
        {
            try
            {
                Conexion2 con = new Conexion2();
                SqlCommand comando = new SqlCommand(query, con.conectar());
                int res = comando.ExecuteNonQuery();
                con.cerrar();
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                return false;
            }


        }
        //sirve para verificar si exixte un registro
        public bool existe(string query)
        {
            Conexion2 con = new Conexion2();

            SqlCommand comando = new SqlCommand(query, con.conectar());
            //comando.Parameters.AddWithValue("@nombre", nombre);
            int count = Convert.ToInt32(comando.ExecuteScalar());

            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //sirve para llenar una datagrid, devuelve un datable para añadir a un gri
        public DataTable llenarVistas(string query)
        {
            DataTable y = new DataTable();
            try
            {
                Conexion2 con = new Conexion2();
                SqlDataAdapter adap = new SqlDataAdapter(query, con.conectar());
                adap.Fill(y);
                con.cerrar();
                return y;

            }
            catch (Exception e)
            {
                return y;
            }

        }
        public string[] ObtenerInformacionAddProduct(string query)
        {
            try
            {
                string[] datos = new string[4];
                Conexion2 con = new Conexion2();
                SqlCommand comando = new SqlCommand(query, con.conectar());
                //comando.Parameters.AddWithValue(@num_control,id);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    datos[0] = registro["idProductos"].ToString();
                    datos[1] = registro["nombre"].ToString();
                    datos[2] = registro["descripcion"].ToString();
                    datos[3] = registro["precioVenta"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos con esa ID");
                    datos = null;
                }
                con.cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar");
                return null;
            }

        }
        public string[] geInfoReservacion(string query)
        {
            try
            {
                string[] datos = new string[11];
                Conexion2 con = new Conexion2();
                SqlCommand comando = new SqlCommand(query, con.conectar());
                //comando.Parameters.AddWithValue(@num_control,id);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    datos[0] = registro["fechaSalida"].ToString();
                    datos[1] = registro["fechaRegreso"].ToString();
                    datos[2] = registro["nombre"].ToString();
                    datos[3] = registro["ubicacion"].ToString();
                    datos[4] = registro["Precio"].ToString();
                    datos[5] = registro["total"].ToString();
                    datos[6] = registro["anticipo"].ToString();
                    datos[7] = registro["restante"].ToString();
                    datos[8] = registro["deposito"].ToString();
                    datos[9] = registro["descripcionUbicacion"].ToString();
                    datos[10] = registro["descuento"].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontraron datos con esa ID");
                    datos = null;
                }
                con.cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar");
                return null;
            }

        }
        //public string[] ObtenerReservacionesMutuas(string query)
        //{
        //    try
        //    {
        //        string[] datos = new string[3];
        //        Conexion con = new Conexion();
        //        SqlCommand comando = new SqlCommand(query, con.conectar());
        //        //comando.Parameters.AddWithValue(@num_control,id);
        //        SqlDataReader registro = comando.ExecuteReader();

        //        if (registro.Read())
        //        {

        //            datos[0] = registro["idReservacion"].ToString();
        //            datos[1] = registro["descripcion"].ToString();
        //            datos[2] = registro["precioVenta"].ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontraron datos con esa ID");
        //            datos = null;
        //        }
        //        con.cerrar();
        //        return datos;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error al consultar");
        //        return null;
        //    }

        //}
        //public DataRow llenarRow(string query)
        //{
        //    DataRow y;
        //    try
        //    {
        //        Conexion con = new Conexion();
        //        SqlDataAdapter adap = new SqlDataAdapter(query, con.conectar());
        //        adap.Fill(y);
        //        con.cerrar();
        //        return y;
        //    }
        //    catch (Exception e)
        //    {
        //        return y;
        //    }
        //}
        //newProdID = (Int32)cmd.ExecuteScalar();
        public int getId(string query)
        {
            int id;
            try
            {
                Conexion2 con = new Conexion2();

                SqlCommand comando = new SqlCommand(query, con.conectar());
                //comando.Parameters.AddWithValue("@nombre", nombre);
                id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
            }
            catch
            {
                id = 1;
            }
            return id;
        }
        //public int getUnDato(string query)
        //{
        //    Conexion2 con = new Conexion2();

        //    SqlCommand comando = new SqlCommand(query, con.conectar());
        //    //comando.Parameters.AddWithValue("@nombre", nombre);
        //    int id = Convert.ToInt32(comando.ExecuteScalar());

        //    return id;
        //}
        public string getUnDato(string query)
        {
            string id = "";
            try
            {
                Conexion2 con = new Conexion2();
                //Conexion con = new Conexion();

                SqlCommand comando = new SqlCommand(query, con.conectar());
                //conectar();
                //comando.Parameters.AddWithValue("@nombre", nombre);
                id = Convert.ToString(comando.ExecuteScalar());
                //cerrar();

            }
            catch
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
            return id;
        }
        public String[] telefono(String query)
        {
            String[] datos = new string[1];
            conectar();
            comando = con.CreateCommand();
            comando.CommandText = query;
            reader = comando.ExecuteReader();

            if (reader.Read())
            {
                datos[0] = reader["telefono"].ToString();
            }
            con.Close();
            return datos;
        }
        public String[] nombre(String query)
        {
            String[] datos = new string[1];
            conectar();
            comando = con.CreateCommand();
            comando.CommandText = query;
            reader = comando.ExecuteReader();

            if (reader.Read())
            {
                datos[0] = reader["name"].ToString();
            }
            con.Close();
            return datos;
        }
        public void select(ComboBox cb, string query)
        {
            try
            {
                Conexion2 con = new Conexion2();
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand(query, con.conectar());
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString());
                }

                con.cerrar();
            }
            catch
            {

            }

        }

        public string[] verInfoReserva(string query)
        {
            try
            {
                string[] datos = new string[12];
                Conexion2 con = new Conexion2();
                SqlCommand comando = new SqlCommand(query, con.conectar());
                //comando.Parameters.AddWithValue(@num_control,id);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    datos[0] = registro["idReserva"].ToString();
                    datos[1] = registro["fechaReserva"].ToString();
                    datos[2] = registro["fechaSalida"].ToString();
                    datos[3] = registro["fechaRegreso"].ToString();
                    datos[4] = registro["nombre"].ToString();
                    datos[5] = registro["telefono"].ToString();
                    datos[6] = registro["ubicacion"].ToString();
                    datos[7] = registro["descripcionUbicacion"].ToString();
                    datos[8] = registro["total"].ToString();
                    datos[9] = registro["anticipo"].ToString();
                    datos[10] = registro["restante"].ToString();
                    datos[11] = registro["deposito"].ToString();
                    //datos[9] = registro["descripcionUbicacion"].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontraron datos con esa ID");
                    datos = null;
                }
                con.cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar");
                return null;
            }

        }

        public string[] verInfoTicket(string query)
        {
            try
            {
                string[] datos = new string[13];
                Conexion2 con = new Conexion2();
                SqlCommand comando = new SqlCommand(query, con.conectar());
                //comando.Parameters.AddWithValue(@num_control,id);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    datos[0] = registro["idReserva"].ToString();
                    datos[1] = registro["fechaReserva"].ToString();
                    datos[2] = registro["fechaSalida"].ToString();
                    datos[3] = registro["fechaRegreso"].ToString();
                    datos[4] = registro["nombre"].ToString();
                    datos[5] = registro["telefono"].ToString();
                    datos[6] = registro["ubicacion"].ToString();
                    datos[7] = registro["Precio"].ToString();
                    datos[8] = registro["descripcionUbicacion"].ToString();
                    datos[9] = registro["total"].ToString();
                    datos[10] = registro["anticipo"].ToString();
                    datos[11] = registro["restante"].ToString();
                    datos[12] = registro["deposito"].ToString();
                    //datos[9] = registro["descripcionUbicacion"].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontraron datos con esa ID");
                    datos = null;
                }
                con.cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar");
                return null;
            }

        }

    }
}

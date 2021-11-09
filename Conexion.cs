using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Sistema_Reservaciones
{
    class Conexion
    {
        //datos de conexion
        //SqlConnection conex = new SqlConnection("Data Source=DESKTOP-09LLDOK\\LOLIS;Initial Catalog=Sistema_Renta_Mobiliario;Integrated Security=True");
        SqlConnection conex = new SqlConnection("Data Source=DESKTOP-K6GJS3D;Initial Catalog=Sistema_Renta_Mobiliario;Integrated Security=True");
        SqlCommand comando;
        SqlDataReader reader;
        public void conectar()
        {
            try
            {
                conex.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar" + e.ToString(), "Error");
                throw;
            }
        }

        //funciones diana
        public DataTable grafica(String query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conex);
                adaptador.Fill(dt);
            }
            catch {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores","Atencion");
            }
            return dt;
        } 

        public void select(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                conectar();

                SqlCommand cmd = new SqlCommand("select nombre from Categorias", conex);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[0].ToString() == cb.Text) { }
                    else { cb.Items.Add(dr[0].ToString()); }
                }
                conex.Close();
            }
            catch
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
           
        }
        //public void select2(ComboBox cb,string query)
        //{
        //    try
        //    {
        //        cb.Items.Clear();
        //        conectar();

        //        SqlCommand cmd = new SqlCommand("select nombre from Categorias", conex);
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            if (dr[0].ToString() == cb.Text) { }
        //            else { cb.Items.Add(dr[0].ToString()); }
        //        }
        //        conex.Close();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
        //    }

        //}

        public void grid(DataGridView gv, string query)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conex);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                gv.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
           
        }

        public void Alta_baja_cambio(String query)
        {
            try
            {
                conectar();
                comando = conex.CreateCommand();
                comando.CommandText = query;
                comando.ExecuteNonQuery();

                conex.Close();
            }
            catch
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
            
        }

        public String[] dato(String query)
        {
            String[] datos = new string[1];
            try
            {
                conectar();
                comando = conex.CreateCommand();
                comando.CommandText = query;
                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    datos[0] = reader["dato"].ToString();
                }
                //else {
                //    datos[0] = "1";
                //}
                conex.Close();
            }
            catch
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
            
            return datos;
        }

        ////funciones david
       // SqlConnection con;
        ////SqlCommand comando;
        ////SqlDataReader reader;
        //public Conexion()
        //{
        //    //cadena conexion
        //    //necesaria para conectar a una bdd en otra compu
        //    con = new SqlConnection("Server=DESKTOP-K6GJS3D;Database=Sistema_Renta_Mobiliario;integrated security=true");
        //}
        //private SqlConnection conectar()
        //{
        //    try
        //    {
        //        con.Open();
        //        //MessageBox.Show("Conexion exitosa");
        //        return con;
        //    }
        //    catch (Exception e)
        //    {
        //        //MessageBox.Show("Error al conectar con la bdd");
        //        return null;

        //    }
        //}
 
        private bool cerrar()
        {
            try
            {
                conex.Close();
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
                //Conexion con = new Conexion();
                SqlCommand comando = new SqlCommand(query, conex);
                conectar();
                int res = comando.ExecuteNonQuery();
                cerrar();
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
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
                return false;
            }


        }
       
        //sirve para verificar si exixte un registro
        public bool existe(string query)
        {
            //Conexion con = new Conexion();

            SqlCommand comando = new SqlCommand(query, conex);
            conectar();
            //comando.Parameters.AddWithValue("@nombre", nombre);
            int count = Convert.ToInt32(comando.ExecuteScalar());
            cerrar();
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
                //Conexion con = new Conexion();
                SqlDataAdapter adap = new SqlDataAdapter(query, conex);
                conectar();
                adap.Fill(y);
                cerrar();
                return y;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
                return y;
            }

        }

        public string[] ObtenerInformacionAddProduct(string query)
        {
            try
            {
                string[] datos = new string[4];
                //Conexion con = new Conexion();
                SqlCommand comando = new SqlCommand(query, conex);
                conectar();
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
               cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
                return null;
            }

        }

        public string[] geInfoReservacion(string query)
        {
            try
            {
                string[] datos = new string[11];
                //Conexion con = new Conexion();
                SqlCommand comando = new SqlCommand(query, conex);
                conectar();
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
                cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
                return null;
            }

        }

        public int getId(string query)
        {
            int id;
            try
            {
                //Conexion con = new Conexion();

                SqlCommand comando = new SqlCommand(query, conex);
                conectar();
                //comando.Parameters.AddWithValue("@nombre", nombre);
                id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                cerrar();
            }
            catch
            {
                id = 1;
            }
            return id;
        }

        public string getUnDato(string query)
        {
            string id="";
            try
            {
                //Conexion con = new Conexion();

                SqlCommand comando = new SqlCommand(query, conex);
                conectar();
                //comando.Parameters.AddWithValue("@nombre", nombre);
                id = Convert.ToString(comando.ExecuteScalar());
                cerrar();
                
            }
            catch {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
            return id;
        }

        public String[] telefono(String query)
        {
            String[] datos = new string[1];
            try
            {
                //Conexion con = new Conexion();
                conectar();
                comando = conex.CreateCommand();
                comando.CommandText = query;
                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    datos[0] = reader["telefono"].ToString();
                }
                cerrar();
            }
            catch {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
            return datos;
        }

        public String[] nombre(String query)
        {
            String[] datos = new string[1];
            try
            {
                //Conexion con = new Conexion();
                conectar();
                comando = conex.CreateCommand();
                comando.CommandText = query;
                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    datos[0] = reader["name"].ToString();
                }
                cerrar();
            }
            catch {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }
            return datos;
        }

        public void select(ComboBox cb, string query)
        {
            try
            {
                //Conexion con = new Conexion();
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand(query, conex);
                conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString());
                }

                cerrar();
            }
            catch
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
            }

        }

        public string[] verInfoReserva(string query)
        {
            try
            {
                string[] datos = new string[12];
                //Conexion con = new Conexion();
                SqlCommand comando = new SqlCommand(query, conex);
                conectar();
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
                cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
                return null;
            }

        }

        public string[] verInfoTicket(string query)
        {
            try
            {
                string[] datos = new string[14];
                //Conexion con = new Conexion();
                SqlCommand comando = new SqlCommand(query, conex);
                conectar();
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
                    datos[13] = registro["descuento"].ToString();
                    //datos[9] = registro["descripcionUbicacion"].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontraron datos con esa ID");
                    datos = null;
                }
                cerrar();
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
                return null;
            }

        }
    }
}

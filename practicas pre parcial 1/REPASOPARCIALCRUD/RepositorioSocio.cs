using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace REPASOPARCIALCRUD
{
    public class RepositorioSocio
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=club;Trusted_Connection=True;";
        
        public bool OK()
        {
            try
            {
                SqlConnection connection = new SqlConnection(cadenaConexion);
                connection.Open();
                
            }
            catch
            {             
                return false;
            }

            return true;
        }

        public List<Socio> ListadoSocio()
        {
            List<Socio> socios = new List<Socio>();

            string query = "select id,nombre,apellido,dni,fecha_nacimiento,numero_socio,cuota_al_dia from Socios";

            using(SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Socio ss = new Socio();

                        ss.Id = reader.GetInt32(0);
                        ss.Nombre = reader.GetString(1);
                        ss.Apellido = reader.GetString(2);
                        ss.DNI = int.Parse(reader.GetString(3));
                        ss.FechaNacimiento = reader.GetDateTime(4);
                        ss.NumSocio = reader.GetInt32(5);
                        ss.CuotaAlDia = reader.GetBoolean(6);

                        socios.Add(ss);
                    }

                    reader.Close();

                    connection.Close();

                }
                catch (Exception ex) 
                {
                    throw new Exception("Error de lista " + ex.Message);
                }
            }

            return socios;
        }
        //   string query = "select id,nombre,apellido,dni,fecha_nacimiento,numero_socio,cuota_al_dia from Socios"
        public void Agregar(string nom, string apell, int dni,DateTime fecha,int numSoc, bool cuota)
        {
            string query = "insert into Socios(nombre,apellido,dni,fecha_nacimiento,numero_socio,cuota_al_dia) values " + 
                "(@nombre,@apellido,@dni,@fecha_nacimiento,@numero_socio,@cuota_al_dia)";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@apellido", apell);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                comando.Parameters.AddWithValue("@numero_socio", numSoc);
                comando.Parameters.AddWithValue("@cuota_al_dia", cuota);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error de carga" + ex.Message);
                }
            }

        }

        public void Modificar(int id, string nom, string apell, int dni, DateTime fecha, int numSoc, bool cuota)
        {
            // nombre,apellido,dni,fecha_nacimiento,numero_socio,cuota_al_dia
            string query = "update Socios set nombre=@nombre,apellido=@apellido,dni=@dni,fecha_nacimiento=@fecha_nacimiento,numero_socio=@numero_socio,cuota_al_dia=@cuota_al_dia " + 
                "where Id=@id";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@apellido", apell);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                comando.Parameters.AddWithValue("@numero_socio", numSoc);
                comando.Parameters.AddWithValue("@cuota_al_dia", cuota);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error de carga" + ex.Message);
                }
            }
        }

        public Socio BuscarID(int? Id)
        {
            string query = "select id,nombre,apellido,dni,fecha_nacimiento,numero_socio,cuota_al_dia from Socios " 
                + "where Id=@id";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", Id);


                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();
                    
                    Socio ss = new Socio();
                    ss.Id = reader.GetInt32(0);
                    ss.Nombre = reader.GetString(1);
                    ss.Apellido = reader.GetString(2);
                    ss.DNI = int.Parse(reader.GetString(3));
                    ss.FechaNacimiento = reader.GetDateTime(4);
                    ss.NumSocio = reader.GetInt32(5);
                    ss.CuotaAlDia = reader.GetBoolean(6);

                    reader.Close();
                    connection.Close();

                    return ss;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error de metodo " + ex.Message);
                }
            }
        }

        public void Eliminar(int Id)
        {
            string query = "delete from Socios " + "where Id=@id";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", Id);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception ex) 
                {
                    throw new Exception("Error al eliminar" + ex.Message);
                }
            }
        }

        //Un método que permita calcular la cantidad de socios con la cuota al día.
        public List<Socio> CantidadSocios()
        {
            List<Socio> soc = new List<Socio>();

            string query = "select id,numero_socio,cuota_al_dia from Socios " + "where cuota_al_dia = 1";

            using(SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query,connection);
                
                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while(reader.Read())
                    {
                        Socio socio = new Socio
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            NumSocio = Convert.ToInt32(reader["numero_socio"]),
                            CuotaAlDia = Convert.ToBoolean(reader["cuota_al_dia"])
                        };

                        soc.Add(socio);
                    }                    
                }
                catch( Exception ex)
                {
                    throw new Exception("Error " + ex.Message);
                }
            }

            return soc;
        }

        //Un método que, dada una edad ingresada por el usuario, muestre todos los socios mayores a esa edad.
        public int CalcularEdad(DateTime fecha)
        {
            int edad = DateTime.Today.Year - fecha.Year;

            // Si todavía no cumplió años este año, se resta 1
            if (fecha.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public List<Socio> MayoresEdad()
        {
            int minima = 18;

            List<Socio> soc = new List<Socio>();

            string query = "select id,nombre,fecha_nacimiento from Socios";

            using(SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
               
                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Socio socio = new Socio
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombre = reader["nombre"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]),
                        };

                        int edadSocio = CalcularEdad(socio.FechaNacimiento);

                        if (edadSocio >= minima)
                        {
                            soc.Add(socio);
                        }
                    }

                }
                catch(Exception ex) 
                {
                    throw new Exception("Error de metodo " + ex.Message);
                }

            }

            return soc;
        }

    }
}

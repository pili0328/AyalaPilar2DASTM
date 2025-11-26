using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SeguimosPracticando
{
    public class RepositorioAdolescentes
    {
        private string conexion = "Server=localhost\\SQLEXPRESS;Database=boliche;Trusted_Connection=True;";

        public bool OK()
        {
            try
            {
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public List<Adolescente> ListadoAdolescentes()
        {
            List<Adolescente> adol = new List<Adolescente>();
            string query = "select id,nombre,apellido,edad,fecha_nacimiento from Adolescentes ";

            using(SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Adolescente dol = new Adolescente();

                        dol.Id = reader.GetInt32(0);
                        dol.Nombre = reader.GetString(1);
                        dol.Apellido = reader.GetString(2);
                        dol.Edad = reader.GetInt32(3);
                        dol.FechaNacimiento = reader.GetDateTime(4);

                        adol.Add(dol);
                    }

                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex) 
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
            return adol;
        }

        public void Agregar(string nom,string apell, int edad, DateTime fecha)
        {
            string query = "insert into Adolescentes (nombre,apellido,edad,fecha_nacimiento) values " + "(@nombre,@apellido,@edad,@fecha_nacimiento)";

            using(SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre",nom);
                comando.Parameters.AddWithValue("@apellido",apell);
                comando.Parameters.AddWithValue("@edad", edad);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fecha);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
        }

        public Adolescente BuscoId(int? id)
        {

            string query = "select id,nombre,apellido,edad,fecha_nacimiento from Adolescentes " + " where id=@id";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id",id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();
                    Adolescente dol = new Adolescente();

                    dol.Id = reader.GetInt32(0);
                    dol.Nombre = reader.GetString(1);
                    dol.Apellido = reader.GetString(2);
                    dol.Edad = reader.GetInt32(3);
                    dol.FechaNacimiento = reader.GetDateTime(4);

                    reader.Close();
                    connection.Close();

                    return dol; 

                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
        }

        public void Modificar(int id,string nom, string apell, int edad, DateTime fecha)
        {
            string query = "update Adolescentes set nombre=@nombre,apellido=@apellido,edad=@edad,fecha_nacimiento=@fecha_nacimiento " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@apellido", apell);
                comando.Parameters.AddWithValue("@edad", edad);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fecha);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "delete from Adolescentes" + " where id=@id";

            using(SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }

            }

        }

        public List<Adolescente> mayoresEdad()
        {
            List<Adolescente> adol = new List<Adolescente>();

            string query = "select id,nombre,edad from Adolescentes " + "where edad > 18";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Adolescente dol = new Adolescente
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Edad = Convert.ToInt32(reader["edad"]),
                        };

                        adol.Add(dol);
                    }

                    reader.Close();
                    connection.Close();
                   

                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }

            return adol;
        }

        public List<Adolescente> ApellidoAyala()
        {
            List<Adolescente> adol = new List<Adolescente>();
            string query = "select nombre,apellido from Adolescentes " + "where apellido = 'ayala' ";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query,connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Adolescente dol = new Adolescente
                        {
                            Nombre = Convert.ToString(reader["nombre"]),
                            Apellido = Convert.ToString(reader["apellido"]),
                        };

                        adol.Add(dol);

                    }

                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }


            return adol;
        }

    }
}

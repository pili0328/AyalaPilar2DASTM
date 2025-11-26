using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace QUINCES
{
    public class RepositorioInvitado
    {
        private string cadena = "Server=localhost\\SQLEXPRESS;Database=cumple;Trusted_Connection=True;";

        public bool OK()
        {
            try
            {
                SqlConnection connection = new SqlConnection(cadena);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Persona> ListadoInvitado()
        {
            List<Persona> inv = new List<Persona>();

            string query = "select id,nombre,apellido,fecha_nacimiento,num_invitado,invitado from XV ";

            using(SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Persona per = new Persona();

                        per.Id = reader.GetInt32(0);
                        per.Nombre = reader.GetString(1);
                        per.Apellido = reader.GetString(2);
                        per.FechaNacimiento = reader.GetDateTime(3);
                        per.NumInvitado = reader.GetInt32(4);
                        per.MeInvitaron = reader.GetBoolean(5);

                        inv.Add(per);
                    }

                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex) 
                {
                    throw new Exception( "Error !! "+ex.Message);
                }
            }
            return inv;
        }

        public void Agregar(string nom,string apell,DateTime fecha, int numIn, bool invi)
        {
            string query = "insert into XV (nombre,apellido,fecha_nacimiento,num_invitado,invitado) values " + 
                "(@nombre,@apellido,@fecha_nacimiento,@num_invitado,@invitado)";

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nombre",nom);
                comando.Parameters.AddWithValue("@apellido", apell);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                comando.Parameters.AddWithValue("@num_invitado", numIn);
                comando.Parameters.AddWithValue("@invitado", invi);

                try
                {
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error !! " + ex.Message);
                }
            }
        }

        public Persona BuscoId(int? id)
        {
            string query = "select id,nombre,apellido,fecha_nacimiento,num_invitado,invitado from XV " + 
                "where id=@id";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();

                    Persona per = new Persona();
                    per.Id = reader.GetInt32(0);
                    per.Nombre = reader.GetString(1);
                    per.Apellido = reader.GetString(2);
                    per.FechaNacimiento = reader.GetDateTime(3);
                    per.NumInvitado = reader.GetInt32(4);
                    per.MeInvitaron = reader.GetBoolean(5);

                    reader.Close();
                    connection.Close();

                    return per;

                }
                catch (Exception ex)
                {
                    throw new Exception("Error !! " + ex.Message);
                }
            }
        }

        public void Modificar(int id,string nom, string apell, DateTime fecha, int numIn, bool invi)
        {
            string query = "update XV set nombre=@nombre,apellido=@apellido,fecha_nacimiento=@fecha_nacimiento,num_invitado=@num_invitado,invitado=@invitado " + "where id=@id";

            using(SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query,connection);
                comando.Parameters.AddWithValue("id",id);
                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@apellido", apell);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                comando.Parameters.AddWithValue("@num_invitado", numIn);
                comando.Parameters.AddWithValue("@invitado", invi);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error !! " + ex.Message);
                }
            }

        }

        public void Eliminar(int id)
        {
            string query = "delete from XV " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(cadena))
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
                    throw new Exception("Error !! " + ex.Message);
                }
            }
        }

        public List<Persona> InvitadosSioSi()
        {
            List<Persona> p = new List<Persona>();

            string query = "select id,nombre,apellido,fecha_nacimiento,num_invitado,invitado from XV " + "where invitado = 1";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Persona persona = new Persona
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Apellido = Convert.ToString(reader["apellido"]),
                            FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]),
                            NumInvitado = Convert.ToInt32(reader["num_invitado"]),
                            MeInvitaron = Convert.ToBoolean(reader["invitado"]),
                        };
                        p.Add(persona);
                    }

                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error !! " + ex.Message);
                }
            }

            return p;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TP01CRUDSQL
{
    public class PersonaDB
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=TP01CRUDSQL;Trusted_Connection=True;";

        public bool OK()
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

            } 
            catch 
            {
                return false;
            }
            return true;
          
        }

        public List<Persona> Obtener()
        {
            List<Persona> persona = new List<Persona>();

            string query = "select id,name,age,gender from TP01";

            using (SqlConnection coneccion = new SqlConnection(connectionString))
            {
                // recibe la consulta que necesita de la base de datos
                SqlCommand comando = new SqlCommand(query, coneccion);

                // como la tenemos?

                try
                {
                    coneccion.Open();

                    // lee la base de datos
                    SqlDataReader leer = comando.ExecuteReader();

                    // lo va a leer hasta el final
                    while (leer.Read())
                    {
                        Persona per = new Persona();

                        per.Id = leer.GetInt32(0);
                        per.Nombre = leer.GetString(1);
                        per.Edad = leer.GetInt32(2);
                        per.Genero = leer.GetString(3);

                        persona.Add(per);
                    }

                    leer.Close();

                    coneccion.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return persona;
        }

        public void Agregar(string Nombre, int Edad, string Genero)
        {
            string query = "insert into TP01(name,age,gender) values" + "(@name,@age,@gender) ";

            using (SqlConnection coneccion = new SqlConnection(connectionString))
            {
                // recibe la consulta que necesita de la base de datos
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@name", Nombre);
                comando.Parameters.AddWithValue("@age", Edad);
                comando.Parameters.AddWithValue("@gender", Genero);

                try
                {
                    coneccion.Open();

                    // lee la base de datos
                    comando.ExecuteNonQuery();

                    coneccion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }

        //Modificar
        public void Editar(string Nombre, int Edad, string Genero, int Id)
        {
            string query = "update TP01 set Name=@name,Age=@age,Gender=@gender" + 
                " where Id=@id";

            using (SqlConnection coneccion = new SqlConnection(connectionString))
            {
                // recibe la consulta que necesita de la base de datos
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@name", Nombre);
                comando.Parameters.AddWithValue("@age", Edad);
                comando.Parameters.AddWithValue("@gender", Genero);
                comando.Parameters.AddWithValue("@id", Id);

                try
                {
                    coneccion.Open();

                    // lee la base de datos
                    comando.ExecuteNonQuery();

                    coneccion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }

        // solo regresa el primer objeto que encuentra
        public Persona RegresaId(int? Id)
        {          
            string query = "select id,name,age,gender from TP01" + 
                " where id=@id";

            using (SqlConnection coneccion = new SqlConnection(connectionString))
            {
                // recibe la consulta que necesita de la base de datos
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@id", Id);
                // como la tenemos?

                try
                {
                    coneccion.Open();

                    // lee la base de datos
                    SqlDataReader leer = comando.ExecuteReader();

                    // lo va a leer hasta el final
                    leer.Read();

                    Persona per = new Persona();

                    per.Id = leer.GetInt32(0);
                    per.Nombre = leer.GetString(1);
                    per.Edad = leer.GetInt32(2);
                    per.Genero = leer.GetString(3);

                    leer.Close();

                    coneccion.Close();
                    return per;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }            
        }

        public void Eliminar(int Id)
        {
            string query = "delete from TP01" +
                " where Id=@id";

            using (SqlConnection coneccion = new SqlConnection(connectionString))
            {
                // recibe la consulta que necesita de la base de datos
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@id", Id);

                try
                {
                    coneccion.Open();

                    // lee la base de datos
                    comando.ExecuteNonQuery();

                    coneccion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }
    }
}

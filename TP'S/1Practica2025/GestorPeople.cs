using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Practica2025
{
    public class GestorPeople
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=practica1;Trusted_Connection=True;";

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

        public List<People> ListadoP()
        {
            List<People> pipi = new List<People>();

            string query = "select Id,Nombre,Edad,CAST(Mayor AS bit),CAST(Menor AS bit) from personitas";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader leer = comando.ExecuteReader();
                   //  ¿Cómo funciona bit en SQL Server?
                   // 0 = false 1 = true

                    while (leer.Read())
                    {
                        People per = new People();

                        per.Id = leer.GetInt32(0);
                        per.Nombre = leer.GetString(1);
                        per.Edad = leer.GetInt32(2);
                        per.Mayor = leer.GetBoolean(3);
                        per.Menor = leer.GetBoolean(4);

                        pipi.Add(per);
                    }

                    leer.Close();

                    connection.Close();

                }
                catch(Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return pipi;

        }

        public void Agregar(string Nom, int Edad, bool May, bool Men)
        {
            string query = "insert into personitas(nombre,edad,mayor,menor) values" + "(@Nombre,@Edad,@Mayor,@Menor)";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query,connection);

                comando.Parameters.AddWithValue("@Nombre", Nom);
                comando.Parameters.AddWithValue("@Edad", Edad);
                comando.Parameters.AddWithValue("@Mayor", May);
                comando.Parameters.AddWithValue("@Menor", Men);


                try
                {
                    connection.Open();

                    comando.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }

        public void Modificar(string Nom, int Edad, int Id, bool May, bool Men)
        {
            string query = "update personitas set Nombre=@Nombre,Edad=@Edad,Mayor=@Mayor,Menor=@Menor " + 
                "where Id=@Id";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                comando.Parameters.AddWithValue("@Nombre", Nom);
                comando.Parameters.AddWithValue("@Edad", Edad);
                comando.Parameters.AddWithValue("@Id", Id);
                comando.Parameters.AddWithValue("@Mayor", May);
                comando.Parameters.AddWithValue("@Menor", Men);


                try
                {
                    connection.Open();

                    comando.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }

        // Buscar el id para eliminar el dato
        public People DevolverId(int? Id)
        {
            string query = "select Id,Nombre,Edad,CAST(Mayor AS bit),CAST(Menor AS bit) from personitas " + "where Id=@Id";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@Id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader leer = comando.ExecuteReader();
                    
                    leer.Read();
                    
                    People per = new People();
                    
                    per.Id = leer.GetInt32(0);
                    per.Nombre = leer.GetString(1);
                    per.Edad = leer.GetInt32(2);
                    per.Mayor = leer.GetBoolean(3);
                    per.Menor = leer.GetBoolean(4);
                    
                    leer.Close();
                    connection.Close();

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
            string query = "delete from personitas " + "where Id=@Id";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@Id", Id);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }
    }
}

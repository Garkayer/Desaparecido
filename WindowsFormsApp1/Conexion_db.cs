using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria DB
using System.Data;
//libreria DB con SQL Server
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String Cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Busqueda.mdf;Integrated Security=True";
            miConexion.ConnectionString = Cadena;
            miConexion.Open();
        }
        public DataSet obtener_datos()
        {

            ds.Clear();
            comandosSQL.Connection = miConexion;


            comandosSQL.CommandText = "select * from Entrevistado";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Entrevistado");


            comandosSQL.CommandText = "select * from Desaparecido";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Desaparecido");

            comandosSQL.CommandText = "select * from Registro";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Registro");






            return ds;
        }


        
        


        public void mantenimiento_datos_desaparecido(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Desaparecido (NombreCompleto, Edad, Sexo, PreferenciaSexual) VALUES(" +

                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                    ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Desaparecido SET " +
                " NombreCompleto              = '" + datos[1] + "'," +
                " Edad           = '" + datos[2] + "'," +
                " Sexo            = '" + datos[3] + "'," +
                " PreferenciaSexual                 = '" + datos[4] + "'" +
                " WHERE IdDesaparecido     = '" + datos[0] + "'";


            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Desaparecido FROM Desaparecido WHERE IdDesaparecido='" + datos[0] + "'";

            }
            procesarSQL(sql);
        }


        public void mantenimiento_datos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Entrevistado (NombreCompleto, FechaEntrevista, FechaNacimiento, Pais) VALUES(" +

                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                    ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Entrevistado SET " +
                " NombreCompleto              = '" + datos[1] + "'," +
                " FechaEntrevista           = '" + datos[2] + "'," +
                " FechaNacimiento            = '" + datos[3] + "'," +
                " Pais                 = '" + datos[4] + "'" +
                " WHERE IdEntrevistado     = '" + datos[0] + "'";


            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Entrevistado FROM Entrevistado WHERE IdEntrevistado='" + datos[0] + "'";

            }
            procesarSQL(sql);
        }

        public void Contacto(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Registro (Telefono, UltimaVez, Nombre) VALUES(" +

                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'" +
                    ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Registro SET " +
                " Telefono              = '" + datos[1] + "'," +
                " UltimaVez           = '" + datos[2] + "'," +
                " Nombre            = '" + datos[3] + "'," +
                " WHERE IdRegistro     = '" + datos[0] + "'";


            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Registro FROM Registro WHERE IdRegistro='" + datos[0] + "'";

            }
            procesarSQL(sql);
        }


        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }

    }
}


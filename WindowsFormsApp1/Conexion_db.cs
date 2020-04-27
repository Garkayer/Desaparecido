using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria para trabajar con BD
using System.Data;
using System.Data.SqlClient; //Libreria para conectarse una BD de SQL Server

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
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Busqueda.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }

        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Entrevistado";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Entrevistado");

            comandosSQL.CommandText = "select * from Persona desaparecida";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Desaparecido");


            return ds;
        }
        public void mantenimiento_datos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Entrevistado (Nombre completo,Fecha de entrevista,País,Departamento,Municipio,Cantón) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Entrevistado SET " +
                    "Nombre completo         = '" + datos[1] + "'," +
                    "Fecha de entrevista         = '" + datos[2] + "'," +
                    "País      = '" + datos[3] + "'," +
                    "Departamento      = '" + datos[4] + "'," +
                    "Municipio            = '" + datos[5] + "'," +
                    "Cantón            = '" + datos[6] + "'" +
                    "WHERE IdEntrevistado = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Entrevistado FROM clientes WHERE IdEntrevistado='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Persona desaparecida (idCategoria,codigo,nombre,marca,presentacion) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE productos SET " +
                    "IdDesaparecido      = '" + datos[1] + "'," +
                    "Nombre completo           = '" + datos[2] + "'," +
                    "Edad           = '" + datos[3] + "'," +
                    "Sexo            = '" + datos[4] + "'," +
                    "Preferencia Sexual     = '" + datos[5] + "'" +
                    "WHERE IdDesaparecido = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Persona desaparecida FROM productos WHERE IdDesaparecido='" + datos[0] + "'";
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


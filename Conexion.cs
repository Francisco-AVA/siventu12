using System.Data;
using System;
using System.Data.SqlClient;

namespace APP_SIVENTU
{
    class Conexion
    {
        private static SqlConnection conexion()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nelso\\Desktop\\APP_SIVENTU\\APP_SIVENTU\\databaseSIVENTU.mdf;Integrated Security=True");

            return conn;
        }

        public DataSet readQuery(string query,string table)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conexion());//conexion
            DataSet ds = new DataSet();
            da.Fill(ds,table); //llenado de dataset

            return ds;
        }

        public DataRow[] readQuery(string query, string table, bool datarow)
        {
            DataTable tb = readQuery(query,table).Tables[table];
            DataRow[] rows = tb.Select();

            return rows; //si se lo quitas el readQuery queda en rojo 7w7
        }

        public bool setData(string query)//Para registrar los datos
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion());
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();//ejecuta la query

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }


    }
}

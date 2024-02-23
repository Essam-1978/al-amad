using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAcess
{
    public class DAL
    {

        private SqlConnection con;
        public DAL()
        {
           // Server = ESSAM - LAPTOP - DE\SQLEXPRESS; Database = Store; Integrated Security = True
            //Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Al_Amad; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False
            con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database = Al-Amad; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        }


        public void open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                 }
           
        }

        public void close()
        {
            if (con.State != ConnectionState.Closed)
            { con.Close(); }
        }




        public DataTable Select_Data(string storedproc, SqlParameter[] param)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = storedproc;
            com.Connection = con;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    com.Parameters.Add(param[i]);
                }
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;

        }


        public void Execute_Com(string storedproc, SqlParameter[] param)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = storedproc;
            com.Connection = con;
            if (param != null)
            {
                com.Parameters.AddRange(param);
               
                com.ExecuteNonQuery();



            }
        }



    }
}

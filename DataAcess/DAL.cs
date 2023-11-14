using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAcess
{
    class DAL
    {

        private SqlConnection con;
        public DAL()
        {
            con = new SqlConnection(@"(localdb)\ProjectsV13;Initial Catalog=Database1_1;Integrated Security=True;Pooling=False;Connect Timeout=30");

        }


        public void open()
        {
            if (con.State != ConnectionState.Open)
            { con.Open(); }
        }

        public void close()
        {
            if (con.State != ConnectionState.Closed)
            { con.Close(); }
        }




        public DataTable Select_Data(string StoredProc, SqlParameter[] param)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = StoredProc;
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


        public void Execute_Com(string StoredProc, SqlParameter[] param)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = StoredProc;
            if (param != null)
            {
                com.Parameters.AddRange(param);
                com.ExecuteNonQuery();



            }
        }



    }
}

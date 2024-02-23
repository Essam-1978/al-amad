using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class BaseRep
    {
        public SqlConnection con { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataReader reader { get; set; }
        public List<SqlParameter> parameters { get; set; }


        public BaseRep()
        {
            
            con = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database = Al-Amad; Integrated Security = True; Connect Timeout = 30; Encrypt = False;  ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            reader = null;

        }






        // Open and Close connection

        public void Connect()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Disconnect()
        {
            if (con == null)
            {
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

        // END connect and disconnect


        public void Execute_Query(string sqlQuery)
        {

            command = new SqlCommand(sqlQuery, con);
            if (parameters != null)
            {
                if (parameters.Count > 0)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

            }

            reader = command.ExecuteReader();


        }

    }
}

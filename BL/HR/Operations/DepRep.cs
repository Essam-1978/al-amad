using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BL.HR.Operations
{
    public class DepRep:BaseRep
    {


        public List<Dep> get_dep()
        {
            List<Dep> items = new List<Dep>();

            Connect();
            Execute_Query("select * from Departments");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Dep dep = new Dep(reader);
                    items.Add(dep);
                }
            }
                       
            Disconnect();
            return (items);
         }


        public Dep get_dep_by_id(int id)
        {

            Connect();
            Dep dep = new Dep();

            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter { ParameterName="@id", SqlDbType=SqlDbType.Int, Value= id});

            Execute_Query("select * from Departments where Dep_Id=@id");

            if (reader.HasRows == true)
            {
                reader.Read();
                dep = new Dep(reader);
            }
            
            Disconnect();
            return dep;

        }


        public void add_dep(Dep newdep)
        {
            Connect();

            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter { ParameterName = "@Name", SqlDbType = SqlDbType.NChar, Value = newdep.Name });
            parameters.Add(new SqlParameter { ParameterName = "@createdate", SqlDbType = SqlDbType.DateTime, Value = newdep.createdate });
            parameters.Add(new SqlParameter { ParameterName = "@editdate", SqlDbType = SqlDbType.DateTime, Value = newdep.editdate });
            parameters.Add(new SqlParameter { ParameterName = "@agentid", SqlDbType = SqlDbType.Int, Value = newdep.agentid });

            SqlCommand insertcommand = new SqlCommand(@"insert into Departments 
            (Dep_Name,Create_Date,Edit_Date,Agent_Id)
            values (@Name,@createdate,@editdate,@agentid)",con);
            insertcommand.Parameters.AddRange(parameters.ToArray());

            insertcommand.ExecuteNonQuery();

            Disconnect();

        }




        public void update_dep(Dep updatedep, int id)
        {

            Connect();

            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter { ParameterName = "@Name", SqlDbType = SqlDbType.NChar, Value = updatedep.Name });
            parameters.Add(new SqlParameter { ParameterName = "@createdate", SqlDbType = SqlDbType.DateTime, Value = updatedep.createdate });
            parameters.Add(new SqlParameter { ParameterName = "@editdate", SqlDbType = SqlDbType.DateTime, Value = updatedep.editdate });
            parameters.Add(new SqlParameter { ParameterName = "@agentid", SqlDbType = SqlDbType.Int, Value = updatedep.agentid });
            parameters.Add(new SqlParameter { ParameterName = "@id", SqlDbType = SqlDbType.Int, Value = id });




            SqlCommand updatecommand = new SqlCommand(@"
            Update Departments set
                Dep_Name=@Name,
                Create_Date=@createdate,
                Edit_Date=@editdate,
                Agent_Id=@agentid where Dep_Id=@id
            ", con);
            updatecommand.Parameters.AddRange(parameters.ToArray());

            updatecommand.ExecuteNonQuery();


            Disconnect();



        }





        // get all deps
        

        public List<Dep> getitems()
        {
            List<Dep> ll = new List<Dep>();

            Connect();
            Execute_Query("select * from Departments");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Dep dep = new Dep(reader);
                    ll.Add(dep);
                    
                }
            }

            Disconnect();

            return ll;
        }


    }
}

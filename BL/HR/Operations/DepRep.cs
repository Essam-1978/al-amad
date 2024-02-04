using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BL.HR.Operations
{
    public class DepRep:BaseRep
    {
        // get all deps
        public DataTable Get_Depatrments()
        {
            DataTable dt = new DataTable();
            DataColumn dtid = new DataColumn();
            dtid.DataType = typeof(Int16);
            DataColumn dtname = new DataColumn();
            dtname.DataType = typeof(string);
            dt.Columns.Add(dtid);dt.Columns.Add(dtname);

            Connect();
            Execute_Query("select Dep_Name from Departments");
            if (reader.HasRows==true)
            {
                while (reader.Read()) { 
                
                    Dep dep = new Dep(reader);

                    
                }


            }

            dt.Load(reader);

            Disconnect();
            return dt;
            
        } 



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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAcess;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class Dep
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public List<Emp> Employees { set; get; }

        DAL db = new DAL();

        // CURD operations

        public void insert_department()
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NChar, 10);
            param[0].Value = Name;

             
           db.open();
            
            db.Execute_Com("insert_cat", param);
            db.close();


        }



        // CURD Operations end


    }
}
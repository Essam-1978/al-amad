using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BL.HR;
using DataAcess;
using System.Data.SqlClient;
using BL.HR.Operations;
using BL;

namespace ConsoleTEST
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // this is first test we shall maek
            // first write connection
            // second write try catch finally to check conn
            // in try open connection initialize reader, command, execute command in reader
            // writeln data

            //SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=Al_Amad;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //try
            //{
            //    con.Open();
            //    SqlDataReader rd = null;
            //    SqlCommand com = new SqlCommand("select * from [dbo].[all_deps] ",con);
            //    rd = com.ExecuteReader();

            //    if (rd.HasRows)
            //    {


            //    while (rd.Read())
            //    {
            //            Dep dep = new Dep(rd);

            //        Console.WriteLine("{0} - {1}",rd["Dep_Id"].ToString(), rd["Dep_Name"].ToString());

            //    }

            //    }

            //    else { Console.WriteLine("No DATA"); }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadLine();
            //}
            //finally
            //{
            //    Console.ReadLine();
            //    con.Close();
            //}




            DepRep tt = new DepRep();
            DataTable ee = new DataTable();
            ee=tt.Get_Depatrments();

            //List<Dep> rr = tt.getitems();
            //foreach (Dep f in rr)
            //{
            //    Console.WriteLine(f.Id);
            //}

            
           
            






        }
        

    }
}

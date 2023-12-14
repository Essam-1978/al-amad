using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BL
{
    public class BaseModel
    {

        public BaseModel()
        {

        }

        public BaseModel(SqlDataReader reader)
        {
            Datareader = reader;
            createdate = DateTime.Parse(Datareader["Create_Date"].ToString());
            editdate = DateTime.Parse(Datareader["Edit_Date"].ToString());

        }

        public SqlDataReader Datareader { get; set; }
        public DateTime createdate { get; set; }
        public DateTime editdate { get; set; }

    }
}

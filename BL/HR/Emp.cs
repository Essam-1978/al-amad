using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.HR
{
    class Emp
    {
        public int Id { set; get; }
        public string First_Name { set; get; }

        public string Mid_Name { set; get; }

        public string Last_Name { set; get; }

        public DateTime Birth_Date { set; get; }

        public byte[] Photo { set; get; }

        public byte[] Badge_Id_front { set; get; }

        public byte[] Badge_Id_back { set; get; }

        public string Address { set; get; }

        public string Mobile { set; get; }

        public DateTime Hire_Date { set; get; }

        public Dep Department { set; get; }






    }
}

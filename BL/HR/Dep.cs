
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BL
{
    public class Dep
    {
        public int Id {get; set; }


        public string Name { get; set; }

        public List<Emp> Employees { set; get; }
    }
}